using System.Text;

namespace DesafioAluraPOO
{
    public class Episodio
    {
        public Episodio(int numero, int duracao, string titulo)
        {

            Numero = numero;
            Duracao = duracao;
            Titulo = titulo;
            convidadosList = new();
        }

        public int Numero { get; }
        public int Duracao { get; }
        public string Titulo { get; }
        public string Resumo => $"Episódio {Numero}: {Titulo} com duração de {new TimeSpan(0, 0, 0, 0, Duracao)} com a participação de {RetornarConvidados()}";

        private readonly List<Convidado> convidadosList;

        public void AdicionarConvidado(Convidado convidado)
        {
            convidadosList.Add(convidado);
        }

        string RetornarConvidados()
        {
            StringBuilder retorno = new StringBuilder();
            foreach (var convidado in convidadosList)
                retorno.Append($"{convidado.Nome}, ");
            if (!retorno.Length.Equals(0))
                return retorno.ToString().Substring(0, retorno.Length - 2);
            else
                return "nenhum convidado neste epísodio.";
        }
    }
}