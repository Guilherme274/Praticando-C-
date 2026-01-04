namespace PraticandoC_;

public class Ex10
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, string especie, int idade)
        {
            Nome = nome; 
            Especie = especie;
            Idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine($"{Nome}, da espécie: {Especie}, com {Idade} ano(s). Está emitindo som");
        }
    }

    public class Chimpanze : Animal
    {
        public Chimpanze(string nome, string especie, int idade) : base(nome, especie, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"Chimpanzé, da espécie: {Especie}, com {Idade} ano(s). Está emitindo som");
        }
    }

    public static void Executar()
    {
        
    }
}
