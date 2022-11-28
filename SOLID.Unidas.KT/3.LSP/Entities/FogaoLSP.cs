namespace _3.LSP
{
    public class FogaoLSP : ProductLSP
    {
        public FogaoLSP(string nomeProduto, decimal precoProduto) : base(nomeProduto, precoProduto)
        {
        }

        public override string ObterCaracteristica()
        {
            return "Fogao 4 bocas";
        }
    }
}