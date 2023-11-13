namespace CriaFolhetoOferta
{
    internal class Tema
    {
        public int Id { get; private set; }
        public string NomeImagem { get; private set; }
        public string NomeTema { get; private set; }

        public Tema(int id, string nomeImagem, string nomeTema)
        {
            Id = id;
            NomeImagem = nomeImagem;
            NomeTema = nomeTema;
        }
    }
}
