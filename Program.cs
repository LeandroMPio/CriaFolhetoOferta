using CriaFolhetoOferta.Cases;

namespace CriaFolhetoOferta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filial CotiaCentro = new("Cotia centro", 59, "Av. Professor José Barreto 1217", "(11) 4666-9000");
            Usuario Leandro = new("Leandro", "leandr999999", "senha", "CPD", 1, CotiaCentro);
            UsuarioCase Usuarios = new();

            Usuarios.Cadastrar(Leandro);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
            Usuarios.Deletar(Leandro.Id);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
        }
    }
}