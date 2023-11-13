namespace CriaFolhetoOferta
{
    internal class Usuario : Pessoa
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public string Setor { get; private set; }
        public int Nivel { get; private set; }
        public Filial Filial  { get; private set; }

        public Usuario(string nome, string login, string password, string setor, int nivel, Filial filial)
        {
            Id = new Random().Next(9999);
            Nome = nome;
            Login = login;
            Password = password;
            Setor = setor;
            Nivel = nivel;
            Filial = filial;
            Filial.Usuarios.Add(this);
        }
    }
}
