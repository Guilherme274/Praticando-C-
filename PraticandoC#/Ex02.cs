using System.Net;

namespace PraticandoC_
{
    public class Ex02
    {
        class RegistroCompras
        {
            public DateOnly data { get; set; }
            public DateTime hora { get; set; }
            public string produto { get; set; }   
            List<RegistroCompras> registros = new List<RegistroCompras>();
            public RegistroCompras(DateOnly data, DateTime hora, string produto)
            {
                this.data = data;
                this.hora = hora;
                this.produto = produto;
            }

            public void AdicionarCompra(RegistroCompras registro)
            {   
                Console.WriteLine("Registro Adicionado");
                registros.Add(registro);
            }
            
            public void ListarCompras()
            {
                Console.WriteLine("Listagem de Registros");
                foreach(RegistroCompras registro in registros)
                {
                    Console.WriteLine($"\n   Data: {registro.data} \n   Hora: {registro.hora} \n   Produto: {registro.produto}");
                }
            }
        }

        public static void Executar()
        {
            // Criando registros
            RegistroCompras registro1 = new RegistroCompras(DateOnly.MaxValue, DateTime.Now, "Tênis");
            RegistroCompras registro2 = new RegistroCompras(DateOnly.MaxValue, DateTime.Now, "Mochila");
            registro1.AdicionarCompra(registro1);
            registro1.AdicionarCompra(registro2);

            registro1.ListarCompras();

        }
    }
}
