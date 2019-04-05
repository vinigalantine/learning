using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
        }
        
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Vinícius";
            Console.WriteLine(p.Name);
        }
    }
}