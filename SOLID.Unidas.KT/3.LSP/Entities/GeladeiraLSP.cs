namespace _3.LSP
{
    public class GeladeiraLSP : ProductLSP
    {
        public GeladeiraLSP(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }

        public override string ObterCaracteristica()
        {
            return "Geladeira Frost Free";
        }
    }
}