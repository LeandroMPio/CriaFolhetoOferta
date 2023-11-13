using CriaFolhetoOferta.Cases;

namespace CriaFolhetoOferta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filial CotiaCentro = new("Cotia centro", 59, "Av. Professor José Barreto 1217", "(11) 4666-9000");
            Usuario Leandro = new("Leandro", "leandr999999", "senha", "CPD", 1, CotiaCentro);
						Produto CocaColaLata = new(7699, "REF.COCA-COLA LATA - 350ML", "UND");
            UsuarioCase Usuarios = new();
						FilialCase Filiais = new();
						ProdutoCase Produtos = new();


						//Usuario
            Usuarios.Cadastrar(Leandro);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
            Usuarios.Deletar(Leandro.Id);
            Usuarios.ListarTodosElementos();
            Usuarios.ListarUmElemento(Leandro.Id);
						Console.WriteLine("");
						Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");

						//Filial
						Filiais.Cadastrar(CotiaCentro);
						Filiais.ListarTodosElementos();
						Filiais.ListarUmElemento(CotiaCentro.Id);
						Filiais.Deletar(CotiaCentro.Id);
						Filiais.ListarTodosElementos();
						Filiais.ListarUmElemento(CotiaCentro.Id);
						Console.WriteLine("");
						Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");			

						//Produto
						Produtos.Cadastrar(CocaColaLata);
						Produtos.ListarTodosElementos();
						Produtos.ListarUmElemento(CocaColaLata.CodigoInterno);
						Produtos.Deletar(CocaColaLata.CodigoInterno);
						Produtos.ListarTodosElementos();
						Produtos.ListarUmElemento(CocaColaLata.CodigoInterno);
						Console.WriteLine("");
						Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx\n");



									Console.ReadLine();


        }
    }
}