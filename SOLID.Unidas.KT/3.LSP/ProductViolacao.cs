namespace _3.LSP
{
    public class ProductViolacao
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public ProductViolacao(string nomeProduto, decimal precoProduto)
        {
            Nome = nomeProduto;
            Preco = precoProduto;
        }

        public string ObterCaracteristicaProduto(ProductViolacao produto)
        {
            if (produto is GeladeiraViolacao)
            {
                return ObterCaracteristicaGeladeira(produto as GeladeiraViolacao);
            }

            if (produto is FogaoViolacao)
            {
                return ObterCaracteristicaFogao(produto as FogaoViolacao);
            }

            return null;
        }

        public string ObterCaracteristicaGeladeira(GeladeiraViolacao produto)
        {
            return $"{produto.Nome}: geladeira duplex";
        }

        public string ObterCaracteristicaFogao(FogaoViolacao produto)
        {
            return $"{produto.Nome}: fogão 6 bocas";
        }
    }
}