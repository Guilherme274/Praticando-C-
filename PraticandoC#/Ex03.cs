using System.Globalization;

namespace PraticandoC_
{
    public class Ex03
    {
        class Imovel
        {
            public string Endereco { get; set; }
            public float Preco { get; set; }
            public string Tipo { get; set; }
        }

         class CorretoraDeImoveis
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
                Console.WriteLine("Imóvel Adicionado");
                imoveis.Add(imovel);
                Console.WriteLine();
            }

            public void ListarImoveis()
            {
                foreach(Imovel imovel in imoveis)
                {
                    Console.WriteLine($"Endereço: {imovel.Endereco}, valendo R${imovel.Preco}, do tipo: {imovel.Tipo}");
                    Console.WriteLine();
                }
            }

            public float CalcularValorMedio()
            {
                float precoTotal = 0;
                foreach(Imovel imovel in imoveis)
                {
                    precoTotal += imovel.Preco;
                }

                return (precoTotal)/imoveis.Count();
            }

            public void AlterarPreco(string endereco, float novoPreco)
            {
                
            }
        }
    }
}
