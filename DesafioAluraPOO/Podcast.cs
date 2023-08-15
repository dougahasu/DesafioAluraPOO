namespace DesafioAluraPOO
{
    public class Podcast
    {
        public Podcast(string nome, string host)
        {
            Nome = nome;
            Host = host;
            episodiosList = new();
        }

        public string Nome { get; }
        public string Host { get; }
        public int TotalEpsodios => episodiosList.Count;

        private readonly List<Episodio> episodiosList;

        public void AdicionarEpisodio(Episodio ep)
        {
            episodiosList.Add(ep);
        }

        public void ExibirDetalhes()
        {
            TimeSpan tsTotal = new();

            Console.WriteLine($"Bem vindo ao {Nome} Podcast, apresentado por {Host}");
            foreach (var ep in episodiosList)
            {
                Console.WriteLine(ep.Resumo);

                tsTotal += new TimeSpan(0, 0, 0, 0, ep.Duracao);
            }
            Console.WriteLine($"\nTemos {TotalEpsodios} com a dutação total de {tsTotal}");
        }
    }
}
