using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ola, qual e seu nome?");
            var nome = Console.ReadLine();
            while (!nome.Contains("sair"))
            {
                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine($"digite um nome por favor");

                }
                else
                {
                    Console.WriteLine($"seja bem vindo {nome}");
   
                }
                nome = Console.ReadLine();

            }
            Console.ReadLine();


        }
    }
}
