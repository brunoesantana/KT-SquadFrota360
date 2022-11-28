namespace _2.OCP
{
    public class ProdutoViolacao
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProdutoViolacao(string nomeProduto, decimal precoProduto)
        {
            Nome = nomeProduto;
            Preco = precoProduto;
        }

        public void AplicarDesconto()
        {
            if (Nome == "Geladeira")
                Preco = Preco * .8m;
            if (Nome == "Fogao")
                Preco = Preco * .75m;
            if (Nome == "Armario")
                Preco = Preco * .75m;
        }
    }
}