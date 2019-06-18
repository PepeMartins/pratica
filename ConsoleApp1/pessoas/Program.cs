using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> Lista = new List<Pessoa>();

            for (int i = 0; i < 10; i++)
            {
                Lista.Add(new Pessoa {
                    Nome = $"Pessoa {i}",
                    Idade = i

                });
            }

            foreach(var item in Lista)
            {
                Console.WriteLine($"Olá me chamo {item.Nome}, tenho {item.Idade} de idade");

            }

            pause();
        }
        static void pause()
        {
            Console.WriteLine("Precione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

   public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Falar(string msg)
        {
            Console.WriteLine(msg);   
        }

    }
}
