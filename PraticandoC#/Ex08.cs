using System.Security.Cryptography;

namespace PraticandoC_;

public class Ex08
{
    public class Fabricante
    {
        private string? _nome;
        public string Nome { 
                get
                {
                    return _nome!;
                }  
                set
                {
                if(value == "")
                    {
                        throw new ArgumentException("O campo Nome deve ser preenchido");
                    }

                    _nome = value;
                } 
            }
        public string? Endereco { get; set; }
        public string? Cidade { get; set; }

      
    }

    public class Produto
    {
        public string? Nome { get; set; }
        public Fabricante? fabricante { get; set; }
        private float _preco;
        public float Preco {
                get
                {
                    return _preco;
                } 
                set
                {
                    if(value < 0)
                    {
                        throw new ArgumentException("O campo de Preço deve ser positivo");        
                    }
                } 
            }
    }

    public static void Executar()
    {
        
    }
}
