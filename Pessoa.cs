using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta
{
    internal abstract class Pessoa
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
    }
}
