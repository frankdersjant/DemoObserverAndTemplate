using System;

namespace ConsoleAppObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject AM = new Subject("Apple Mobile", 1000);

            Observer user1 = new Observer("Joe", AM);
            Observer user2 = new Observer("Sara", AM);

            Console.WriteLine("Current price : " + AM.getCurrentprice());
            Console.WriteLine();

            AM.SetPrice(1005);
            Console.Read();
        }
    }
}
