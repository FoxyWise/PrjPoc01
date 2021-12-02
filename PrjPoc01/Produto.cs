namespace PrjPoc01
{
    class Produto
    {
        public enum TipoProdutoEnum { Nacional = 1, Importado = 2 }
        public int Codigo { get; set; }
        public String Descricao { get; set; }
        public Decimal Valor { get; set; }
        public TipoProdutoEnum TipoProduto { get; set; }
        public Decimal ValorVenda { get; set; }

    }
}