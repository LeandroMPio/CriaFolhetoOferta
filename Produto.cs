namespace CriaFolhetoOferta
{
    internal class Produto
    {
        public int CodigoInterno { get; private set; }
        public string Descricao { get; private set; }
        public string Embalagem { get; private set; }

        public Produto (int codigoInterno, string descricao, string embalagem)
        {
            CodigoInterno = codigoInterno;
            Descricao = descricao;
            Embalagem = embalagem;
        }
    }
}
