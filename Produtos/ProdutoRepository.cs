namespace APIProdutos.Produtos
{
    public class ProdutoRepository
    {
        public bool IncluiProduto(Produto produto)
        {
            return false;
        }
        public bool AlteraProduto(int id, Produto produto)
        {
            return false;
        }
        public List<Produto> ListaProdutos()
        {
            return new List<Produto>();
        }
        public Produto DetalhesProduto(int id)
        {
            return new Produto();
        }
        public bool ExcluiProduto(int id)
        {
            return false;
        }
        public bool ProdutoExiste(Produto produto)
        {
            return false;
        }
    }
}
