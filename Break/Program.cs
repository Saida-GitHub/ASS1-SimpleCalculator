internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        /*
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine("i value is::" + i);
            if (i == 60)
            {
                Console.WriteLine( "Hey i is 60-SO i am going to take a break...");
                break;
            }
        }
        */

        for (int i = 0; i < 100; i++) 
        {
            //Console.WriteLine("i value is ::" + i);
            if (i == 50)
            {
               
                continue;
            
            }
            Console.WriteLine("i value is ::" + i);
            // Console.WriteLine("Hey i value is ::" + i);
        }
    }
}