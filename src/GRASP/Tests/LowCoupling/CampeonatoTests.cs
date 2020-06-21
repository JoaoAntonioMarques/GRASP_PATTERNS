using NUnit.Framework;
using Patterns.LowCoupling;

namespace TestsPatterns.InformationExpert
{
    public class CampeonatoTests
    {
        [Test]
        public void VerificarMensagens()
        {
            var campeonato = new Campeonato(new Corinthians());
            Assert.AreEqual(campeonato.ComecarCampeonato(), "Corinthians entra em campo!");

            campeonato.DefinirTime(new SaoPaulo());
            Assert.AreEqual(campeonato.ComecarCampeonato(), "Sao Paulo entra em campo!");

            campeonato.DefinirTime(new Palmeiras());
            Assert.AreEqual(campeonato.ComecarCampeonato(), "Palmeiras entra em campo!");
        }
    }
}