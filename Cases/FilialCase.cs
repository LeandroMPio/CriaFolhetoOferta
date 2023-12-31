using CriaFolhetoOferta.Interfaces;

namespace CriaFolhetoOferta.Cases
{
		internal class FilialCase : ICadastrar<Filial>, IListar, IEncontrarElemento, IDeletar
		{
			public List<Filial> Filiais { get; private set; } = new();

		public void Cadastrar(Filial entidade)
		{
			Filiais.Add(entidade);
		}
		public object EncontrarUmElemento(int identificacao)
		{
			Filial filialEncontrada = Filiais.FirstOrDefault(x => x.Id.Equals(identificacao));
			return filialEncontrada;
		}

		public void ListarTodosElementos()
		{
			
			if(Filiais.Count == 0) 
			{
				Console.WriteLine("Não existe Filiais cadastradas!");
			}
			else
			{
                Console.WriteLine("Listando Todas Filiais:");
                foreach (Filial filial in Filiais)
				{					
                    Console.WriteLine($"ID:\t{filial.Id}");
                    Console.WriteLine($"Nome:\t{filial.Nome}");
					Console.WriteLine($"Logo:\t{filial.Logo}");
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
                Console.WriteLine($"ID:\t{Filial.Id}");
                Console.WriteLine($"Nome:\t{Filial.Nome}");
                Console.WriteLine($"Logo:\t{Filial.Logo}");
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
				Filiais.Remove(Filial);
				Console.WriteLine($"Filial {Filial.Nome} deletada");
			}
		}
	}
}