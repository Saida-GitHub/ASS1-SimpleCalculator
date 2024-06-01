internal class Program
{
    private static void Main(string[] args)
    {
        int firstnum = 0;
        int secondnum = 0;
        Console.WriteLine("Hello, World!");

        Console.WriteLine("Input the First number:");
        string firstnumIP = Console.ReadLine();
        firstnum = int.Parse(firstnumIP);

        Console.WriteLine("Input the Second number:");
        string secondnumIP = Console.ReadLine();
        secondnum = int.Parse(secondnumIP);

        var final = 0;
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[A]dd numbers.");
        Console.WriteLine("[S]ubstract numbers");
        Console.WriteLine("[M]ultiplay numbers");

        var resultReq = Console.ReadLine();
        if (resultReq != null)
        {
            if (resultReq.Equals("A") || resultReq.Equals("a"))
            {
                final = firstnum + secondnum;
            }
            else if (resultReq.Equals("S") || resultReq.Equals("s"))
            {
                final = firstnum - secondnum;
            }
            else if (resultReq.Equals("M") || resultReq.Equals("m"))
            {
                final = firstnum * secondnum;
            }
            else
            {
                Console.WriteLine("Please enter valid input");
            }
            Console.WriteLine("Result::" + final);
        }
        else
        {
            Console.WriteLine("Please enter valid input");
        }
    }
}