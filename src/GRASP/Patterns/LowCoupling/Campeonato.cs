namespace Patterns.LowCoupling
{
    //ESTE EXEMPLO TBM USA O PATTERN DE ALTA COESAO
    public class Campeonato
    {
        private ITimeFutebol TimeFutebol;
        public Campeonato(ITimeFutebol timeFutebol)
        {
            TimeFutebol = timeFutebol;
        }

        public void DefinirTime(ITimeFutebol timeFutebol)
        {
            TimeFutebol = timeFutebol;
        }

        public string ComecarCampeonato()
        {
            return TimeFutebol.Jogar();
        }
    }
}
