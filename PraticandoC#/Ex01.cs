class Ex01
{

    class Produto
    {
        public string _nome { get; set; }
        public float _preco { get; set; }
        public int _qtdEstoque { get; set; }
    
        public Produto(string nome, float preco, int qtdEstoque )
        {
            _nome = nome;
            _preco = preco;
            _qtdEstoque = qtdEstoque;
        }
    }

    class Loja
    {
        private string? _nome { get; set; }
        List<Produto> estoque = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Console.WriteLine("\nProduto adicionado");
            estoque.Add(produto); 
        }

        public void RemoverProduto(Produto produto)
        {   
            Console.WriteLine("\nProduto removido");
            estoque.Remove(produto);
        }

        public void MostrarProdutos()
        {
           Console.WriteLine("\nProdutos no Estoque:");
           foreach(Produto produto in estoque)
            {   
               Console.WriteLine($"\n   Produto: {produto._nome} \n   Preço: {produto._preco} \n   Quantidade em Estoque: {produto._qtdEstoque}");
            }
        }
    }

    static void Main(string[] args)
    {
        // Instanciando Loja
        Loja kombosa = new Loja();
        // Instanciando Produto;
        Produto milkshake = new Produto("NutMilk", 19.50f, 5);
        Produto agua = new Produto("Água", 5.5f, 50);
        Produto chocolate = new Produto("Chocolate", 7.5f, 20);
        //  Inserindo produto no estoque da Loja
        kombosa.AdicionarProduto(milkshake);
        kombosa.AdicionarProduto(agua);
        kombosa.AdicionarProduto(chocolate);

        // Mostrando Produtos após inserção
        kombosa.MostrarProdutos();
        
        // Removendo Produto
        kombosa.RemoverProduto(agua);

        // Mostrando Produtos após remoção
        kombosa.MostrarProdutos();
    }
}

