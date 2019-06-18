using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Função que lê as notas colocadas
                string nota_a = lerEscrever("entre com a nota A");
                String nota_b = lerEscrever("entre com a nota B");
                string nota_c = lerEscrever("entre com a nota C");
                string nota_d = lerEscrever("entre com a nota D");

                //Função que transforma a letra no numero
                decimal.TryParse(nota_a, out decimal _a);
                decimal.TryParse(nota_b, out decimal _b);
                decimal.TryParse(nota_c, out decimal _c);
                decimal.TryParse(nota_d, out decimal _d);
                Console.WriteLine(((_a + _b + _c + _d)/4));
            }
        }
         //Função que lê e escreve mensagens na tela

        static string lerEscrever(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
    }
}
