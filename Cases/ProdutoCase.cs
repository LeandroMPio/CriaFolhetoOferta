using CriaFolhetoOferta.Interfaces;

namespace CriaFolhetoOferta.Cases
{
	internal class ProdutoCase : ICadastrar<Produto>, IListar, IEncontrarElemento, IDeletar
	{
		public List<Produto> Produtos { get; private set; } = new();

		public void Cadastrar(Produto entidade)
		{
			Produtos.Add(entidade);
		}
		public object EncontrarUmElemento(int identificacao)
		{
				Produto ProdutoEncontrado = Produtos.FirstOrDefault(x => x.CodigoInterno.Equals(identificacao));
				return ProdutoEncontrado;
			}

		public void ListarTodosElementos()
		{
			
			if(Produtos.Count == 0) 
			{
					Console.WriteLine("Não existe Produtos cadastrados!");
			}
			else
			{
					foreach (Produto produto in Produtos)
					{
							Console.WriteLine("Listando Todos Produtos:");
							Console.WriteLine($"Código Interno:\t{produto.CodigoInterno}");
							Console.WriteLine($"Descrição:\t{produto.Descricao}");
							Console.WriteLine($"Embalagem:\t{produto.Embalagem}");
							Console.WriteLine("-------------------------------");
					}
			}
		}

		public void ListarUmElemento(int identificacao)
		{
			Produto Produto = (Produto)EncontrarUmElemento(identificacao);
			if(Produto == null) 
			{
					Console.WriteLine("Produto não encontrado");
			}
			else
			{
					Console.WriteLine($"Listando o Produto informada:");
					Console.WriteLine($"Código Interno:\t{Produto.CodigoInterno}");
					Console.WriteLine($"Descrição:\t{Produto.Descricao}");
					Console.WriteLine($"Embalagem:\t{Produto.Embalagem}");
					Console.WriteLine("-------------------------------");
			}

		}
		public void Deletar(int identificacao)
		{
			Produto Produto = (Produto)EncontrarUmElemento(identificacao);
			if(Produto == null) 
			{
					Console.WriteLine("Produto não encontrado");
			}
			else
			{
				Produtos.Remove(Produto);
				Console.WriteLine($"Produto {Produto.Descricao} deletado");
			}
		}
	}
}