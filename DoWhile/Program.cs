internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var mobile = Console.ReadLine();
        //int MobileNumber = int.Parse(mobile);
        do
        {
            Console.WriteLine("Please enter valid Mobile number..");

        } while (mobile.Length > 10);
        {

        }

        Console.WriteLine("Valid Mobile Number!!");
        Console.ReadKey();
    }
}