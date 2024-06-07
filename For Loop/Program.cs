using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /*
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine("Hello!!");
        }
        */

        //Fact::
        var Input = Console.ReadLine();

        int FactNum = int.Parse(Input);
        int Res = 1;
        for (int i = 1; i <= FactNum; i++)
        {
            Res = Res * i;
        }
        Console.WriteLine(Res);

        
    }
}