using Patterns.LowCoupling;

namespace Patterns.HighCoesion
{
    //ESTE EXEMPLO TBM USA O PATTERN DE ALTA COESAO
    public class CampeonatoErrado
    {
        private ITimeFutebol TimeFutebol;
        public CampeonatoErrado(ITimeFutebol timeFutebol)
        {
            TimeFutebol = timeFutebol;
        }

        public void DefinirTime(ITimeFutebol timeFutebol)
        {
            TimeFutebol = timeFutebol;
        }

        //Isso nao tem nada relacionado com o campeonato em sim, fere o parametro de alta coesao.
        public string VerificarCondicaoMetereologica()
        {
            return "Sol";
        }

        public string ComecarCampeonato()
        {
            return TimeFutebol.Jogar();
        }
    }
}
