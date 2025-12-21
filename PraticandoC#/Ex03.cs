using System.Diagnostics.Contracts;
using System.Globalization;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;

namespace PraticandoC_
{
    public class Ex03
    {
        public class Imovel
        {
            public string Endereco { get; set; }
            public float Preco { get; set; }
            public string Tipo { get; set; }

            public Imovel(string endereco, float preco, string tipo)
            {
                Endereco = endereco;
                Preco = preco;
                Tipo = tipo;
            }
        }

        public class CorretoraDeImoveis
        {
            public string Nome { get; set; }
            public string Email { get; set; }
            public string Telefone { get; set; }
            List<Imovel> imoveis = new List<Imovel>();

            public CorretoraDeImoveis(string nome, string email, string telefone)
            {
                Nome = nome;
                Email = email;
                Telefone = telefone;
            }

            public void AdicionarImovel(Imovel imovel)
            {
                
                imoveis.Add(imovel);
                Console.WriteLine("Imóvel Adicionado");
                Console.WriteLine();
            }

            public void ListarImoveis()
            {
                foreach(Imovel imovel in imoveis)
                {
                    Console.WriteLine($"Endereço: {imovel.Endereco}, valendo R${imovel.Preco}, do tipo: {imovel.Tipo}");
                    Console.WriteLine();
                }
                Console.WriteLine("Listagem Feita");
            }

            public float CalcularValorMedio()
            {
                Console.WriteLine("Média Calculada");
                float precoTotal = 0;
                foreach(Imovel imovel in imoveis)
                {
                    precoTotal += imovel.Preco;
                }

                return (precoTotal)/imoveis.Count();
            }

            public void AlterarPreco(string endereco, float novoPreco)
            {
                Console.WriteLine("Preço Alterado");
                foreach(Imovel imovel in imoveis)
                {
                    if(imovel.Endereco == endereco)
                    {
                        imovel.Preco = novoPreco;
                    }
                }
            }
        }

        public static Imovel RegistroImovel()
        {
            string endereco = "";
            float preco = 0;
            string tipo = "";

            Console.WriteLine("Digite o endereço do Imóvel");
            endereco = Console.ReadLine();
            Console.WriteLine("Digite o Preço do Imóvel");
            preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Tipo do Imóvel");
            tipo = Console.ReadLine();

            return new Imovel(endereco,preco,tipo);
        }

        static void Menu(CorretoraDeImoveis corretora)
        {
            int escolha = 0;

            Console.WriteLine();
            Console.WriteLine("Corretora de Imoveis \n1 - Cadastrar Imóvel \n2 - Lista Imóveis \n3 - Calcular Valor Médio da Corretora \n4 - Alterar Preço de Imóvel");
            
            try
            {
                escolha = int.Parse(Console.ReadLine());

                if(escolha < 1 || escolha > 4)
                {
                    Console.WriteLine("Os valores inseridos, embora sendo números, não estão presentes nas opções do Menu");
                    Ex03.Menu(corretora);
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Valores de texto não são aceitos, só são aceitas as opções presentes no Menu");
                Ex03.Menu(corretora);
            }
            
            switch(escolha)
            {
                case 1: 
                    Imovel imovel = Ex03.RegistroImovel();
                    corretora.AdicionarImovel(imovel);
                    break;
                case 2: 
                    corretora.ListarImoveis();
                    break;
                case 3: 
                    Console.WriteLine("O valor médio dos imóveis da corretora é:" + corretora.CalcularValorMedio());
                    break;
                case 4:
                    string endereco;
                    float novoPreco;

                    Console.WriteLine("Digite o Endereço :");
                    endereco = Console.ReadLine();
                    Console.WriteLine("Digite o Endereço :");
                    novoPreco = float.Parse(Console.ReadLine());
                    corretora.AlterarPreco(endereco, novoPreco);
                    break;
            }

            Ex03.Menu(corretora);
        }

        public static void Executar()
        {
            CorretoraDeImoveis corretora = new CorretoraDeImoveis("GS Corretoras", "gscorretoras@gmail.com", "(13) 97419-4059");
            Ex03.Menu(corretora);
        }
    }
}
