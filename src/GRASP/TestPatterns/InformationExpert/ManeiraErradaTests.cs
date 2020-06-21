using InformationExpert.ManeiraErrada;
using NUnit.Framework;

namespace TestsPatterns.InformationExpert
{
    public class ManeiraErradaTests
    {
        Carrinho Carrinho;

        [SetUp]
        public void Setup()
        {
            Carrinho = new Carrinho();
        }

        [Test]
        public void ValorTotalCarrinho()
        {
            Assert.AreEqual(Carrinho.ObterValorTotal(), 10);
        }
    }
}