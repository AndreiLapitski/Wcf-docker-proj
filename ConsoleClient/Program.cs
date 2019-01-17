using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new StringService.StringServiceClient();
            Console.WriteLine(client.GetYourString("Hi from client!"));
            Console.Read();

        }
    }
}
