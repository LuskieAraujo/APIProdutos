namespace APIProdutos.Produtos
{
    public class ProdutoService
    {
        private ProdutoRepository _repository = new();
        public bool New(Produto p)
        {
            return !ProductExists(p) && _repository.IncluiProduto(p);
        }
        public Produto? Update(int id, Produto p)
        {
            return _repository.AlteraProduto(id, p) ? p : null;
        }
        public bool Delete(int id)
        {
            return _repository.ExcluiProduto(id);
        }
        public Produto Details(int id)
        {
            return _repository.DetalhesProduto(id);
        }
        public List<Produto> Produtos()
        {
            return _repository.ListaProdutos();
        }
        private bool ProductExists(Produto p)
        {
            return _repository.ProdutoExiste(p);
        }
    }
}
