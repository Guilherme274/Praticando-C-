namespace PraticandoC_;

public class Ex05
{
    public class GerenciadorDeTarefas
    {
        public string Nome { get; set; }
        List<Tarefa> tarefas = new List<Tarefa>();

        public GerenciadorDeTarefas(string nome)
        {
            Nome = nome;
        }
        
        public void AdicionarTarefa(Tarefa tarefa)
        {
            tarefas.Add(tarefa);
            Console.WriteLine();
        }
        public void RemoverTarefa(Tarefa tarefa)
        {
            tarefas.Remove(tarefa);
            Console.WriteLine();
        }
        public void ListarTarefas()
        {
            foreach(Tarefa tarefa in tarefas)
            {
                Console.WriteLine($"Descrição: {tarefa.Descricao} \nData de Vencimento:{tarefa.DataVencimento}");   
                Console.WriteLine();             
            }
            Console.WriteLine();
        }

        public string VerificarSeExecutaHoje(Tarefa tarefa)
        {
          return (tarefa.DataVencimento == DateOnly.FromDateTime(DateTime.Now)) ? "Tarefa deve ser executada hoje" : "Tarefa NÃO deve ser execute hoje";
        }
    }

    public class Tarefa
    {
        public string Descricao { get; set; }
        public DateOnly DataVencimento { get; set; }

        public Tarefa(string descricao, DateOnly dataVencimento)
        {
            Descricao = descricao;
            DataVencimento = dataVencimento;
        }
    }

    public static void Executar()
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas("Meu Gerenciador");
        Tarefa tarefa1 = new Tarefa("Lavar a louça", new DateOnly(2025,12,23));
        Tarefa tarefa2 = new Tarefa("Aspirar a casa", new DateOnly(2025,12,28));
        gerenciador.AdicionarTarefa(tarefa1);
        gerenciador.AdicionarTarefa(tarefa2);
        
        gerenciador.ListarTarefas();

        Console.WriteLine(gerenciador.VerificarSeExecutaHoje(tarefa1));
        Console.WriteLine(gerenciador.VerificarSeExecutaHoje(tarefa2));

        gerenciador.RemoverTarefa(tarefa1);

        gerenciador.ListarTarefas();

    }
}
