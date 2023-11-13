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
						FilialCase Filiais = new();


						//Usuario
            Usuarios.Cadastrar(Leandro);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
            Usuarios.Deletar(Leandro.Id);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
						Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

						//Filial
						Filiais.Cadastrar(CotiaCentro);
						Filiais.ListarTodosElementos();
						Filiais.ListarUmElemento(CotiaCentro.Id);
						Filiais.Deletar(CotiaCentro.Id);
						Filiais.ListarTodosElementos();
						Filiais.ListarUmElemento(CotiaCentro.Id);
						Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
						Console.ReadLine();

        }
    }
}