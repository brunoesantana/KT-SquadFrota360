namespace _2.OCP
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        private const decimal DESCONTO_PADRAO = .3M;

        public virtual void AplicarDesconto()
        {
            Preco = Preco * DESCONTO_PADRAO;
        }

        public Produto(string nomeProduto, decimal precoProduto)
        {
            Nome = nomeProduto;
            Preco = precoProduto;
        }
    }
}