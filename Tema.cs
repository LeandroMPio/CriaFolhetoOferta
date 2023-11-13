namespace CriaFolhetoOferta
{
    internal class Tema
    {
        public int Id { get; private set; }
        public string NomeTema { get; private set; }
        public string NomeImagem { get; private set; }

        public Tema(string nomeTema, string nomeImagem)
        {
            Id = new Random().Next(9999);
            NomeTema = nomeTema;
            NomeImagem = nomeImagem;
        }
    }
}
