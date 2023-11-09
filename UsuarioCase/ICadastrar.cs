using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta.UsuarioCase
{
    internal interface ICadastrar<T>
    {
        public void Cadastrar(T entidade);
    }
}
