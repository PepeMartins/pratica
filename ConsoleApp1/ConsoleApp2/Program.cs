using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int venceu = 0;

            Player P1 = new Player
            {
                Nome = "Jogador 1",
                Vida = 100
            };

            Player P2 = new Player
            {
                Nome = "Jogador 2",
                Vida = 100
            };


            while (true)
            {
                Console.Clear();
                if (venceu == 0)
                {


                    Console.WriteLine($"{P1.Nome}/{P1.Vida}------------------------------------{P2.Nome}/{P2.Vida}");
                }
                if (venceu == 1)
                {

                    Console.WriteLine("O Jogador 1 Venceu");
                
                }
                if (venceu == 2)
                {

                    Console.WriteLine("O Jogador 2 Venceu");

                }
                var comando = Console.ReadKey();

                if (P2.Vida > 0)
                {
                    if (comando.Key == ConsoleKey.D1)
                    {
                        P1.soco(P2);
                    }
                    else if (comando.Key == ConsoleKey.D2)
                    {
                        P1.chute(P2);

                    }
                }
                else
                {
                    P2.Vida = 0;
                    venceu = 1;
                }


                if (P1.Vida > 0)
                {
                    

                    if (comando.Key == ConsoleKey.D3)
                    {
                        P2.soco(P1);

                    }
                    else if (comando.Key == ConsoleKey.D4)
                    {
                        P2.chute(P1);

                    }
                }
                else
                {
                    P1.Vida = 0;
                    venceu = 2;
                }

            }
        }
    }
}