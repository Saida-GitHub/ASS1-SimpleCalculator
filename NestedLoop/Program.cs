internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"i value is:{i}j value is :{j}"); ;
            }
        }
    }
}