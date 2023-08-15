using DesafioAluraPOO;

Podcast podcast = new("podIdeiasDev - Seu novo cantinho para falar de Tecnologia", "Douglas");
Episodio ep = new Episodio(1, (int)new TimeSpan(1, 33, 53).TotalMilliseconds, "Piloto");
Convidado convidado = new("João");
ep.AdicionarConvidado(convidado);
convidado = new("Maria");
ep.AdicionarConvidado(convidado);
podcast.AdicionarEpisodio(ep);

ep = new Episodio(2, (int)new TimeSpan(0, 35, 12).TotalMilliseconds, "Minha história");
podcast.AdicionarEpisodio(ep);

ep = new Episodio(3, (int)new TimeSpan(2, 16, 7).TotalMilliseconds, "Como Passar um elefante por baixo da porta");
convidado = new("Lúcio");
ep.AdicionarConvidado(convidado);
convidado = new("Marco");
ep.AdicionarConvidado(convidado);
podcast.AdicionarEpisodio(ep);

podcast.ExibirDetalhes();