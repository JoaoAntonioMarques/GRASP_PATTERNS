using System.Collections.Generic;

namespace Patterns.InformationExpert.ManeiraErrada
{
    public class CarrinhoV2
    {
        readonly List<ProdutoV2> Produtos = new List<ProdutoV2>();

        public CarrinhoV2()
        {
            //CRIANDO O PRODUTO AQUI, TBM USEI O CREATOR
            Produtos.Add(new ProdutoV2(10, 5));
        }

        public int ObterValorTotal()
        {
            int total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.ObterTotal();
            }
            return total;
        }
    }
}
