namespace _2.OCP
{
    public class Armario : Produto
    {
        public Armario(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }

        public override void AplicarDesconto()
        {
            Preco = Preco * .60m;
        }
    }
}