namespace Patterns.InformationExpert.ManeiraErrada
{
    public class ProdutoV2
    {
        private readonly int Preco = 0;
        private readonly int Quantidade = 0;

        public ProdutoV2(int preco, int quantidade)
        {
            Preco = preco;
            Quantidade = quantidade;
        }

        public int ObterTotal()
        {
            return Preco * Quantidade;
        }
    }
}
