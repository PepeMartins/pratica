using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //ler o valor de A
                var a = lerEscrever("Digite o valor de A:");
                //ler o valor de B
                var b = lerEscrever("DIgite o valor de B:");
                //verifica se A e B são numeros decimal, e converte para numeros decimal
                if (decimal.TryParse(a, out decimal _a) && decimal.TryParse(b, out decimal _b))
                {
                 //mostra o valor da soma entre A e B
                    Console.WriteLine(Somar(_a, _b));
                }else {
                    Console.WriteLine("Valores não são numeros inteiros");
                }
                Console.WriteLine("pressione qualquer tecla pra continuar"); Console.ReadLine();
            }

        }
        //função que ler e escreve mensagens na tela
        static string lerEscrever(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        //função que soma dois valores
        static string Somar(decimal a, decimal b)
        {
            return (a + b).ToString();
        }
    }
}
