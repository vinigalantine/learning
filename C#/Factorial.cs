namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(num));

            Console.ReadKey();
        }

        public static int Factorial(int n){
            if (n == 1)
                return 1;
            return n * Factorial(n -1);
        }
    }
}
