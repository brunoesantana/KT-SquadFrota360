namespace _2.OCP
{
    public class Geladeira : Produto
    {
        public Geladeira(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }

        public override void AplicarDesconto()
        {
            Preco = Preco * .8m;
        }
    }
}