namespace InformationExpert.ManeiraErrada
{
    public class Produto
    {
        private readonly int Preco = 0;
        private readonly int Quantidade = 0;

        public Produto(int preco, int quantidade)
        {
            Preco = preco;
            Quantidade = quantidade;
        }
        internal int ObterPreco()
        {
            return Preco;
        }

        public int ObterQuantidade()
        {
            return Quantidade;
        }
    }
}
