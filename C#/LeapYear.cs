using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int year,days;
            string status;
            
            Console.WriteLine("Digite o ano: ");
            year = Convert.ToInt32(Console.ReadLine());
            
            // status = leap year or normal year
            status = (year % 100 != 0 && year % 4 == 0 || year % 400 == 0 ) ? "bisexto" : "normal";
            
            days = (year % 100 != 0 && year % 4 == 0 || year % 400 == 0 ) ? 366 : 365;
            
            
            Console.WriteLine("O ano "+year+" é "+status+" e por isso tem "+days+" dias.");
        }
    }
}
