using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta
{
    internal class Filial
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int NumeroFilial { get; private set; }
        public string Endereco { get; private set; }
        public string Telefone { get; private set; }
        public List<Usuario> Usuarios { get; private set; }

        public Filial (int id, string nome, int numeroFilial, string endereco, string telefone)
        {
            Id = id; 
            Nome = nome;
            NumeroFilial = numeroFilial;
            Endereco = endereco;
            Telefone = telefone;
        }

    }
}
