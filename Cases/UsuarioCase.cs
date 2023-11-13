using CriaFolhetoOferta.Interfaces;

namespace CriaFolhetoOferta.Cases
{
    internal class UsuarioCase : ICadastrar<Usuario>, IListar, IDeletar, IEncontrarElemento
    {
        public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public void Cadastrar(Usuario entidade)
        {
            Usuarios.Add(entidade);
        }
        public void ListarTodosElementos()
        {
            if(Usuarios.Count == 0)
            {
                Console.WriteLine("Não existe usuários cadastrados!");
            } 
            else
            {
                Console.WriteLine("Listando Todos Usuários:");
                foreach (var usuario in Usuarios)
                {
                    Console.WriteLine($"ID:\t{usuario.Id}");
                    Console.WriteLine($"Nome:\t{usuario.Nome}");
                    Console.WriteLine($"Login:\t{usuario.Login}");
                    Console.WriteLine($"Setor:\t{usuario.Setor}");
                    Console.WriteLine($"Filial:\t{usuario.Filial.Nome}");
                    Console.WriteLine("-------------------------------");
                }
            }
        }
        public object EncontrarUmElemento(int identificacao)
        {
			var usuarioEncontrado = Usuarios.FirstOrDefault(x => x.Id.Equals(identificacao));
			return usuarioEncontrado;
        }
        public void ListarUmElemento(int identificacao)
        {
            Usuario Usuario = (Usuario)EncontrarUmElemento(identificacao);
            if(Usuario == null)
            {
                Console.WriteLine("Usuário não encontrado");
            }
            else
            {
                Console.WriteLine($"Listando o usuário informado:");
                Console.WriteLine($"ID:\t{Usuario.Id}");
                Console.WriteLine($"Nome:\t{Usuario.Nome}");
                Console.WriteLine($"Login:\t{Usuario.Login}");
                Console.WriteLine($"Setor:\t{Usuario.Setor}");
                Console.WriteLine($"Filial:\t{Usuario.Filial.Nome}");
				Console.WriteLine("-------------------------------");                
            }
        }

        public void Deletar(int identificacao)
        {
            Usuario Usuario = (Usuario)EncontrarUmElemento(identificacao);
			if(Usuario == null)
            {
                Console.WriteLine("Usuário não encontrado");
            }
			else
			{
				Usuarios.Remove(Usuario);
				Console.WriteLine($"Usuário {Usuario.Nome} deletado");
			}
        }

    }
}
