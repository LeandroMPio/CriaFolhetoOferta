namespace CriaFolhetoOferta
{
    internal class Produto
    {
        public int CodigoInterno { get; private set; }
        public string Descricao { get; private set; }
        public string ImagemProduto { get; private set; }
        public string Embalagem { get; private set; }

        public Produto (int codigoInterno, string descricao, string imagemProduto, string embalagem)
        {
            CodigoInterno = codigoInterno;
            Descricao = descricao;
            ImagemProduto = imagemProduto;
            Embalagem = embalagem;
        }
    }
}
