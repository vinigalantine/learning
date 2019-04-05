namespace Country
{
    class Country
    {
        public static string Name { get; set; }
        protected static int Population { get; set; }
        protected static long Dimension { get; set; }

        public Country()
        {
            Console.WriteLine("Digite o nome do País:");
            Name = Console.ReadLine();

            Console.WriteLine("Digite a população (Número de habitantes):");
            Population = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a dimensão dele (km²):");
            Dimension = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Novo país criado com sucesso! ---------------" );
            Console.WriteLine("Nome: " + Name);
            Console.WriteLine("População: " + Population);
            Console.WriteLine("Dimensão: " + Dimension);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
        }

        private double GetDensidadePop()
        {
            return Population / Dimension;
        }

        public void GetMensagem()
        {
            Console.WriteLine("Nome do País: " + Name);
            Console.WriteLine();
            Console.WriteLine("Densidade Populacional: " + GetDensidadePop());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string validate;
            Console.WriteLine("Deseja criar um novo País?(Y/N)");
            validate = Console.ReadLine();
            if (validate.ToLower() == "y") {
                Country p = new Country();

                Console.WriteLine("Deseja printar a Mensagem?(Y/N)");
                string validate_msg = Console.ReadLine();

                if (validate_msg.ToLower() == "y")
                {
                    p.GetMensagem();
                }

                Console.WriteLine();
                Console.WriteLine("Aperte \"Enter\" para sair.");
                Console.ReadLine();
            }
        }
    }
}