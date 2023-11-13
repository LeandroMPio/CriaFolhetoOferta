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
				Tema filialEncontrada = Temas.FirstOrDefault(x => x.Id.Equals(identificacao));
				return filialEncontrada;
			}

		public void ListarTodosElementos()
		{
			
			if(Temas.Count == 0) 
			{
					Console.WriteLine("Não existe Temas cadastradas!");
			}
			else
			{
					foreach (Filial filial in Temas)
					{
							Console.WriteLine("Listando Todas Temas:");
							Console.WriteLine($"Nome:\t{filial.Nome}");
							Console.WriteLine($"Nº Filial:\t{filial.NumeroFilial}");
							Console.WriteLine($"Endereço:\t{filial.Endereco}");
							Console.WriteLine($"Telefone:\t{filial.Telefone}");
							foreach (Usuario usuario in filial.Usuarios)
							{
								Console.WriteLine("Usuario(s) da Filial:");
								Console.WriteLine($"Nome:\t{usuario.Nome}");
							}
							Console.WriteLine("-------------------------------");
					}
			}
		}

		public void ListarUmElemento(int identificacao)
		{
			Filial Filial = (Filial)EncontrarUmElemento(identificacao);
			if(Filial == null) 
			{
					Console.WriteLine("Filial não encontrada");
			}
			else
			{
					Console.WriteLine($"Listando a Filial informada:");
					Console.WriteLine($"Nome:\t{Filial.Nome}");
					Console.WriteLine($"Login:\t{Filial.NumeroFilial}");
					Console.WriteLine($"Setor:\t{Filial.Endereco}");
					Console.WriteLine($"Filial:\t{Filial.Telefone}");
					foreach (Usuario usuario in Filial.Usuarios)
							{
								Console.WriteLine("Usuario(s) da Filial:");
								Console.WriteLine($"Nome:\t{usuario.Nome}");
							}
					Console.WriteLine("-------------------------------");
			}

		}
		public void Deletar(int identificacao)
		{
			Filial Filial = (Filial)EncontrarUmElemento(identificacao);
			if(Filial == null) 
			{
					Console.WriteLine("Filial não encontrada");
			}
			else
			{
				Temas.Remove(Filial);
				Console.WriteLine($"Filial {Filial.Nome} deletada");
			}
		}
	} 
}