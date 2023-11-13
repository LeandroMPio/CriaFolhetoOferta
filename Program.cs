using CriaFolhetoOferta.Cases;

namespace CriaFolhetoOferta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filial CotiaCentro = new("Cotia centro", 59, "logo059.png", "Av. Professor José Barreto 1217", "(11) 4666-9000");
            Usuario Leandro = new("Leandro", "leandr999999", "senha", "CPD", 1, CotiaCentro);
            Usuario Dalton = new("Dalton", "dalton888888888", "senhaForte", "CPD", 1, CotiaCentro);
			Produto CocaColaLata = new(7699, "REF.COCA-COLA LATA - 350ML", "CocaColaLata.png", "UND");
			Produto PaoQueijo = new(12356, "PÃO QUEIJO F.MINAS TRAD. - 1KG", "PaoQueijo.png", "UND");
			Tema SuperOferta = new("Tema Super Ofertas", "super-ofertas.png");
			Tema SuperSexta = new("Tema Super Sexta", "super-sexta.png");

			FolhetoOferta Folheto1 = new(Leandro, CocaColaLata, SuperOferta);
			FolhetoOferta Folheto2 = new(Dalton, PaoQueijo, SuperSexta);

            UsuarioCase Usuarios = new();
			FilialCase Filiais = new();
			ProdutoCase Produtos = new();
			TemaCase Temas = new();


			//Usuario
			Usuarios.Cadastrar(Leandro);
			Usuarios.Cadastrar(Dalton);
			Usuarios.ListarTodosElementos();
			Usuarios.Deletar(Leandro.Id);
			Usuarios.ListarTodosElementos();
			Usuarios.ListarUmElemento(Leandro.Id);
			Console.WriteLine("");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			//Filial
			Filiais.Cadastrar(CotiaCentro);
			Filiais.ListarTodosElementos();
			Filiais.ListarUmElemento(CotiaCentro.Id);
			Filiais.Deletar(CotiaCentro.Id);
			Filiais.ListarTodosElementos();
			Filiais.ListarUmElemento(CotiaCentro.Id);
			Console.WriteLine("");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			//Produto
			Produtos.Cadastrar(CocaColaLata);
			Produtos.Cadastrar(PaoQueijo);
			Produtos.ListarTodosElementos();
			Produtos.Deletar(CocaColaLata.CodigoInterno);
			Produtos.ListarTodosElementos();
			Produtos.ListarUmElemento(CocaColaLata.CodigoInterno);
            Console.WriteLine("");
            Console.WriteLine("Produto Reflection");
			Produtos.Exibir(PaoQueijo);
            Console.WriteLine("");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			//Tema
			Temas.Cadastrar(SuperOferta);
			Temas.Cadastrar(SuperSexta);
			Temas.ListarTodosElementos();
			Temas.Deletar(SuperOferta.Id);
			Temas.ListarTodosElementos();
			Temas.ListarUmElemento(SuperOferta.Id);
			Console.WriteLine("");
			Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

			//Folheto
			Folheto1.CriarFolheto(2.50);
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
			Folheto2.CriarFolheto(20.55);
        }
    }
}