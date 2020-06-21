using NUnit.Framework;
using Patterns.InformationExpert.ManeiraErrada;

namespace TestsPatterns.InformationExpert
{
    public class ManeiraCorretaTests
    {
        CarrinhoV2 Carrinho;

        [SetUp]
        public void Setup()
        {
            Carrinho = new CarrinhoV2();
        }

        [Test]
        public void ValorTotalCarrinho()
        {
            Assert.AreEqual(Carrinho.ObterValorTotal(), 50);
        }
    }
}