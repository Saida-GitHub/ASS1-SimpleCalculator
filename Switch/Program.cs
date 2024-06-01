internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput))
        {
            int Input = int.Parse(userInput);

            switch (Input)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Week Day");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("WeekEnd");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter input");
        }
    }
}