using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        class Person
        {
            private string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
        }
        
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "Vinícius";
            Console.WriteLine(p.Name);
        }
    }
}