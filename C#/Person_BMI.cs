using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        public string Name { get; set; }
        protected static double Height { get; set; }
        protected static double Weight { get; set; }

        public Person()
        {
            Console.WriteLine("Digite seu nome:");
            Name = Console.ReadLine();

            Console.WriteLine("Digite sua altura (Em metros):");
            Height = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Digite seu peso (Em quilogramas):");
            Weight = Convert.ToDouble(Console.ReadLine().Replace(".",","));

            Console.WriteLine("Olá " + Name + ", sua altura é: " + Height + "m e pesa: " + Weight + "kg");

        }
    }

    // Body Mass Index (Bmi) = Índice de Massa Corporal (Imc)
    class Bmi : Person
    {
        public static double BmiNumber()
        {
            double bmi_number;
            bmi_number = Weight / (Height * Height);
            return Math.Round(bmi_number, 2);
        }

        public static string BmiMeaning(double bmi_number)
        {
            string bmi_msg = "Hi";

            if (bmi_number <= 16.9)
            {
                bmi_msg = "Muito abaixo do peso - 16 a 16,9 kg/m2 - Queda de cabelo, infertilidade, ausência menstrual";
            }
            else if (bmi_number <= 18.4)
            {
                bmi_msg = "Abaixo do peso - 17 a 18,4 kg/m2 - Fadiga, stress, ansiedade";
            }
            else if (bmi_number <= 24.9)
            {
                bmi_msg = "Peso normal - 18,5 a 24,9 kg/m2 - Menor risco de doenças cardíacas e vasculares";
            }
            else if (bmi_number <= 29.9)
            {
                bmi_msg = "Acima do peso - 25 a 29,9 kg/m2 - Fadiga, má circulação, varizes";
            }
            else if (bmi_number <= 34.9)
            {
                bmi_msg = "Obesidade Grau I - 30 a 34,9 kg/m2 - Diabetes, angina, infarto, aterosclerose";
            }
            else if (bmi_number <= 40)
            {
                bmi_msg = "Obesidade Grau II - 35 a 40 kg/m2 - Apneia do sono, falta de ar";
            }
            else
            {
                bmi_msg = "Obesidade Grau III - maior que 40 kg/m2 - Refluxo, dificuldade para se mover, escaras, diabetes, infarto, AVC";
            }

            return bmi_msg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            double bmi_number;
            string bmi_msg;
            Person p = new Person();

            bmi_number = Bmi.BmiNumber();
            bmi_msg = Bmi.BmiMeaning(bmi_number);

            Console.WriteLine("Imc: " + bmi_number);
            Console.WriteLine(bmi_msg);

            Console.ReadKey();
        }
    }
}
