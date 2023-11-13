using CriaFolhetoOferta.Cases;
using CriaFolhetoOferta.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriaFolhetoOferta
{
    internal class FolhetoOferta
    {
        public double Valor { get; private set; }
        public Tema Tema { get; private set; }
        public Usuario Usuario { get; private set; }
        public Produto Produto { get; private set; }

        public FolhetoOferta(Usuario usuario, Produto produto, Tema tema)
        {
            Usuario = usuario;
            Produto = produto;
            Tema = tema;
        }
        public void CriarFolheto(double valor)
        {

            Console.WriteLine("      Oferta gerada com sucesso!");
            Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
            Console.WriteLine($"| {Tema.NomeTema}   {Usuario.Filial.Logo} ");
            Console.WriteLine($"|------------------------------------|");
            Console.WriteLine($"|    {Produto.Descricao}              ");
            Console.WriteLine($"|                                    |");
            Console.WriteLine($"|                                    |");
            Console.WriteLine($"|    {Produto.ImagemProduto}          ");
            Console.WriteLine($"|                                    |");
            Console.WriteLine($"|                                    |");
            Console.WriteLine($"|    {valor.ToString("C")} {Produto.Embalagem}            ");
            Console.WriteLine($"|____________________________________|");
            Console.WriteLine($"|   {Usuario.Filial.Nome}             ");
            Console.WriteLine($"|   {Usuario.Filial.Endereco}         ");
            Console.WriteLine($"|   {Usuario.Filial.Telefone}         ");
            Console.WriteLine( "|____________________________________|");
        }        
    }
}
