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
