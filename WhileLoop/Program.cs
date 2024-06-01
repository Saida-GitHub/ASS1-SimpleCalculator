internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        /*
        int num = 0;

        while (num < 10)
        {
            //num = num + 1;

            //OR
            //num += 2;

            //OR
            //num++;

            //OR
            ++num;
            Console.WriteLine(num);
        }
        Console.WriteLine("Lood completed!!");
        */

        /*
        var userInput = Console.ReadLine();
        while (userInput.Length < 10)
        {
            userInput += '*';
            Console.WriteLine(userInput);
        }
        */
        Console.WriteLine( "Enter First Number:");
        var firstInput = Console.ReadLine();
        int firstNumber = int.Parse(firstInput);

        Console.WriteLine("Enter Last Number:");
        var secondInput = Console.ReadLine();
        int lastNumber = int.Parse(secondInput);
        
        int res = 0;
        while (firstNumber < lastNumber)
        {
            firstNumber++;
            Console.WriteLine(firstNumber);
             res = (firstNumber + firstNumber);
            
        }
        Console.WriteLine("Result :" + res);

    }
}