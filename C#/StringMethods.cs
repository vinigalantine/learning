namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Vinícius";
            Console.WriteLine(text.Length);

            Console.WriteLine(text.IndexOf('n'));

            text = text.Insert(0, "Hi ");
            Console.WriteLine(text);

            text = text.Replace("Hi", "I'm");
            Console.WriteLine(text);

            if(text.Contains("I"))
                Console.WriteLine("found");

            text = text.Remove(3);
            Console.WriteLine(text);

            text = text.Substring(1);
            Console.WriteLine(text);
        }
    }
}