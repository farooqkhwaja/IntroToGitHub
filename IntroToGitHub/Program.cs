namespace IntroToGitHub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("give me your name: ");
            string name = Console.ReadLine();

            Console.WriteLine(name);

            Console.WriteLine("Solve the math problem!");

            int math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(math += 10);


        }
    }
}
