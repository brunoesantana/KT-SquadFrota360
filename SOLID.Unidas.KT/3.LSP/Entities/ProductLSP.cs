namespace _3.LSP
{
    public abstract class ProductLSP
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public abstract string ObterCaracteristica();

        public ProductLSP(string nomeProduto, decimal precoProduto)
        {
            Nome = nomeProduto;
            Preco = precoProduto;
        }

        public string ObterCaracteristicaProduto(ProductLSP produto)
        {
            return produto.ObterCaracteristica();
        }
    }
}