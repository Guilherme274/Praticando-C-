namespace PraticandoC_;

public class Ex09
{
    public class Livro
    {
        private string _titulo;
        public string Titulo {
                get
                {
                    return _titulo;
                } 
                set
                {
                    if(value == null)
                    {
                        throw new Exception("Os valores não podem ser vazios");
                    }
                } 
            }
        private string _autor;
        public string Autor {
                get
                {
                    return _titulo;
                } 
                set
                {
                    if(value == null)
                    {
                        throw new Exception("Os valores não podem ser vazios");
                    }
                }
        }
    }

    public static void Executar()
    {
        Livro livro = new Livro();

        Console.WriteLine(livro.Autor);
    }
}
