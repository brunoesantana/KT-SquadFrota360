namespace _2.OCP
{
    public class Fogao : Produto
    {
        public Fogao(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }

        public override void AplicarDesconto()
        {
            Preco = Preco * .75m;
        }
    }
}