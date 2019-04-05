using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc c = new Calc();
            string response = "";

            while (true)
            {
                Console.WriteLine("Digite um número, operadores matemáticos (+, -, *, /) ou \"E\" para sair:");
                response = Console.ReadLine();

                if(response.ToLower() == "e")
                {
                    Console.WriteLine(c.getLastNumber());
                    break;
                }
                if (response == "+" || response == "-" || response == "*" || response == "/")
                {
                    c.Calculate(response);
                }
                else
                {
                    c.PushToStack(Convert.ToDouble(response));
                }
                                            
            }

            Console.WriteLine("Finzalizado!");
            Console.ReadKey();
        }
    }
}
