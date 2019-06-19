using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Player
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public void soco(Player alvo)
        {
            alvo.Vida -= 10;
        }
        public void chute(Player alvo)
        {
            alvo.Vida -= 15;

        }

    }
}
