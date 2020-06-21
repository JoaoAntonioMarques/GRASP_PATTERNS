using System.Collections.Generic;

namespace InformationExpert.ManeiraErrada
{
    public class Carrinho
    {
        List<Produto> Produtos = new List<Produto>();

        public Carrinho()
        {
            Produtos.Add(new Produto(2, 5));
        }

        public int ObterValorTotal()
        {
            int total = 0;
            foreach (var produto in Produtos)
            {
                total = produto.ObterQuantidade() * produto.ObterPreco();
            }
            return total;
        }
    }
}
