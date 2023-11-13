namespace CriaFolhetoOferta
{
    internal class Filial
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int NumeroFilial { get; private set; }
        public string Logo { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public List<Usuario> Usuarios { get; set; }

        public Filial (string nome, int numeroFilial, string logo, string endereco, string telefone)
        {
            Id = new Random().Next(9999); 
            Nome = nome;
            NumeroFilial = numeroFilial;
            Logo = logo;
            Endereco = endereco;
            Telefone = telefone;
            Usuarios = new();
        }

    }
}
