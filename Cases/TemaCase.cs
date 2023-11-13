using CriaFolhetoOferta.Interfaces;
namespace CriaFolhetoOferta.Cases
{
	internal class TemaCase : ICadastrar<Tema>, IListar, IEncontrarElemento, IDeletar
	{
		public List<Tema> Temas { get; private set; } = new();
		public void Cadastrar(Tema entidade)
		{
			Temas.Add(entidade);
		}
		public object EncontrarUmElemento(int identificacao)
		{
			Tema TemaEncontrado = Temas.FirstOrDefault(x => x.Id.Equals(identificacao));
			return TemaEncontrado;
		}

		public void ListarTodosElementos()
		{
			
			if(Temas.Count == 0) 
			{
				Console.WriteLine("Não existe Temas cadastrados!");
			}
			else
			{
                Console.WriteLine("Listando Todas Temas:");
                foreach (Tema tema in Temas)
				{
					Console.WriteLine($"ID:\t{tema.Id}");
					Console.WriteLine($"Nome:\t{tema.NomeTema}");
					Console.WriteLine($"Imagem:\t{tema.NomeImagem}");
					Console.WriteLine("-------------------------------");
				}
			}
		}

		public void ListarUmElemento(int identificacao)
		{
			Tema Tema = (Tema)EncontrarUmElemento(identificacao);
			if(Tema == null) 
			{
				Console.WriteLine("Tema não encontrado");
			}
			else
			{
				Console.WriteLine($"Listando o Tema informado:");
                Console.WriteLine($"ID:\t{Tema.Id}");
                Console.WriteLine($"Nome:\t{Tema.NomeTema}");
                Console.WriteLine($"Imagem:\t{Tema.NomeImagem}");
                Console.WriteLine("-------------------------------");
            }

		}
		public void Deletar(int identificacao)
		{
            Tema Tema = (Tema)EncontrarUmElemento(identificacao);
            if (Tema == null) 
			{
					Console.WriteLine("Tema não encontrado");
			}
			else
			{
				Temas.Remove(Tema);
				Console.WriteLine($"Tema {Tema.NomeTema} deletada");
			}
		}
	} 
}