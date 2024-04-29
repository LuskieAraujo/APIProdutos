using System.ComponentModel.DataAnnotations;

namespace APIProdutos.Produtos
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int Categoria { get; set; }
        public int Estoque { get; set; }
        public bool Descontinuado { get; set; }
    }
}
