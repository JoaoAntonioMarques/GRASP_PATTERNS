using System.Collections.Generic;

namespace Patterns.Creator
{
    public class Time
    {
        public List<Jogador> Jogadores = new List<Jogador>();

        public Time()
        {
            Jogadores.Add(new Jogador());
        }
    }
}
