using ConsoleClient.TicketService;
using System;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new TicketService.TicketServiceClient();
            Console.WriteLine(client.GetYourString("Hi from client!"));

            var list = client.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.EventName + " - " + item.Price);
            }


            //client.Create(new Ticket() {
            //    EventName = "From concole client",
            //    Price = 666
            //});

            //Console.Read();
        }
    }
}
