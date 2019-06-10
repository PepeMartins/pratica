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
                string temp = lerEscrever("entre com a formula:");
                string[]dados = temp.Split('+', '-', '/', '*');
               
                if (dados.Count() > 1)
                {
                    //ler o valor de A
                    string a = dados[0];
                    //ler o valor de B
                    string b = dados[1];
                    if (temp.Contains("+"))
                    {
                        if (decimal.TryParse(a, out decimal _a) && decimal.TryParse(b, out decimal _b))
                        {
                            //mostra o valor da soma entre A e B
                            Console.WriteLine(Somar(_a, _b));
                        }
                        else
                        {
                            Console.WriteLine("Valores não são numeros inteiros");
                        }

                    }
                    else if (temp.Contains("-"))
                    {
                        if (decimal.TryParse(a, out decimal _a) && decimal.TryParse(b, out decimal _b))
                        {
                            //mostra o valor da soma entre A e B
                            Console.WriteLine(Subtrair(_a, _b));
                        }
                        else
                        {
                            Console.WriteLine("Valores não são numeros inteiros");
                        }


                    }
                    else if (temp.Contains("*"))
                    {
                        if (decimal.TryParse(a, out decimal _a) && decimal.TryParse(b, out decimal _b))
                        {
                            //mostra o valor da soma entre A e B
                            Console.WriteLine(Multiplicar(_a, _b));
                        }
                        else
                        {
                            Console.WriteLine("Valores não são numeros inteiros");
                        }


                    }
                    else if (temp.Contains("/"))
                    {
                        if (decimal.TryParse(a, out decimal _a) && decimal.TryParse(b, out decimal _b))
                        {
                            //mostra o valor da soma entre A e B
                            Console.WriteLine(Dividir(_a, _b));
                        }
                        else
                        {
                            Console.WriteLine("Valores não são numeros inteiros");
                        }


                    }
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

        static string Subtrair(decimal a, decimal b)
        {
            return (a - b).ToString();
        }
        static string Multiplicar(decimal a, decimal b)
        {
            return (a * b).ToString();
        }
        static string Dividir(decimal a, decimal b)
        {
            return (a / b).ToString();
        }
    }
}
