namespace PraticandoC_;

public class Ex04
{
    public class AgendaTelefonica
    {
        public string Nome { get; set; }
        List<Contato> contatos = new List<Contato>();

        public AgendaTelefonica(string nome)
        {
            Nome = nome;
        }

        public void ListarContatos()
        {
            foreach(Contato contato in contatos)
            {
                Console.WriteLine($"{contato.Nome} \nEmail:{contato.Email} \nTelefone{contato.Telefone}");
            }
        }

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public void RemoverContato(Contato contato)
        {
            contatos.Remove(contato);            
        }

        public Contato BuscarContato(string nome)
        {
            var contatoEncontrado = contatos.Find(contato => contato.Nome.Contains(nome));

            return contatoEncontrado!;
        }
    }

    public class Contato
    {
         public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }

    public static void Executar()
    {
        AgendaTelefonica agenda = new AgendaTelefonica("Minha Agenda");

        Contato guilherme = new Contato("Guilherme", "(13) 95419-2046", "guilherme3284@gmail"); 
        Contato joao = new Contato("João", "(13) 94638-6489", "joao2384457@gmail"); 
        agenda.AdicionarContato(guilherme);
        agenda.AdicionarContato(joao);

        Contato contatoEncontrado = agenda.BuscarContato("Guilherme");
        Console.WriteLine($"{contatoEncontrado.Nome} \nEmail: {contatoEncontrado.Email} \nTelefone: {contatoEncontrado.Telefone}");
    
        agenda.RemoverContato(guilherme);
        agenda.ListarContatos();    
    }
}
