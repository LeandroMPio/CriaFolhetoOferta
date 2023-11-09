using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta
{
    internal class Produto
    {
        public string Descricao { get; private set; }
        public string Tipo { get; private set; }
        public int CodigoInterno { get; private set; }

        public Produto (string descricao, string tipo, int codigoInterno)
        {
            Descricao = descricao;
            Tipo = tipo;
            CodigoInterno = codigoInterno;
        }

    }
}
