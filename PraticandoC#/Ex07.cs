namespace PraticandoC_;

public class Ex07
{
    public class Musica
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Gravadora { get; set; }

        public Musica(string nome, string autor, string gravadora)
        {
            Nome = nome;
            Autor = autor;
            Gravadora = gravadora;
        }
    }

    public class Playlist
    {
        public string Dono { get; set; }
        List<Musica> musicas = new List<Musica>();

        public Playlist(string dono)
        {
            Dono = dono;
        }

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
            Console.WriteLine();
        }

        public void ReproduzirMusica(string nome)
        {
            var musicaEncontrada = musicas.Find(musica => musica.Nome == nome);

            Console.WriteLine("Reporduzindo Música");
            Console.WriteLine();
        }

        public void ReproducaoAleatoria()
        {
            var rand = new Random();
            int numRandom = rand.Next(0, 3);

            Console.WriteLine($"Nome: {musicas[numRandom].Nome} \nAutor: {musicas[numRandom].Autor} \nGravadora: {musicas[numRandom].Gravadora}");
        }
        
    }
    public static void Executar()
    {
        Musica musica = new Musica("Freaks", "Surf Curse", "surf grav");
        Musica musica2 = new Musica("Money", "The Drums", "the drums grav");
        Musica musica3 = new Musica("Let Down", "Radio Head", "radio head grav");
        Musica musica4 = new Musica("Young", "Vacations", "vacations grav");

        Playlist playlist = new Playlist("Playlist do Guilherme");
        playlist.AdicionarMusica(musica);
        playlist.AdicionarMusica(musica2);
        playlist.AdicionarMusica(musica3);
        playlist.AdicionarMusica(musica4);

        playlist.ReproduzirMusica("Let Down");

        playlist.ReproducaoAleatoria();
    }
}
