using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackCalculator
{
    class Calc
    {
        public static Pilha nums = new Pilha();

        public void PushToStack(double number)
        {
            nums.Push(number);
        }
     
        public void Calculate(string sing)
        {
            double ret = nums.Pop();

            while (nums.getTop() != 0)
            { 
                if (sing == "+")
                {
                    ret += nums.Pop();
                }
                else if (sing == "-")
                {
                    ret -= nums.Pop();
                }
                else if (sing == "*")
                {
                    ret *= nums.Pop();
                }
                else if (sing == "/")
                {
                    ret /= nums.Pop();
                }
                else
                {
                    ret %= nums.Pop();
                }
            }

            nums.Push(ret);
            Console.WriteLine(ret); 
        }

        public double getLastNumber()
        {
            return nums.Pop();
        }
    }
}
