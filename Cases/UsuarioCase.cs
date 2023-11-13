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
            Usuario usuario = (Usuario)EncontrarUmElemento(identificacao);
            if(usuario == null)
            {
                Console.WriteLine("Usuário não encontrado");
            }
            else
            {
                Console.WriteLine($"Listando o usuário informado:");
                Console.WriteLine($"Nome:\t{usuario.Nome}");
                Console.WriteLine($"Login:\t{usuario.Login}");
                Console.WriteLine($"Setor:\t{usuario.Setor}");
                Console.WriteLine($"Filial:\t{usuario.Filial.Nome}");
            }
        }

        public void Deletar(int identificacao)
        {
            Usuario usuario = (Usuario)EncontrarUmElemento(identificacao);
            Usuarios.Remove(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} deletado");
        }

    }
}
