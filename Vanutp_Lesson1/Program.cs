internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine(" - name");

        Console.WriteLine("what is your age?");
        string age = Console.ReadLine();
        Console.WriteLine($"your age{age}, your age after 10 years: {age + 10}");
        Console.ReadLine();
    }
}