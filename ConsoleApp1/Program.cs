namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max, min;
            Console.WriteLine("Random Number Genarater");
            Console.WriteLine("Enter a minimum Value");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a max value");
            max = int.Parse(Console.ReadLine());
            Random random = new Random();
            Console.WriteLine("\nThe 5 Random numbers between {0} and {1} are:", min, max);
            for (int i = 0; i < 5; i++)
            {
                int
            RandomNumberInRange = random.Next(min, max);
                Console.WriteLine(" {0}, ", RandomNumberInRange);
            }
        }
    }
}