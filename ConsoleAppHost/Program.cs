using System;
using System.ServiceModel;

namespace ConsoleAppHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(WcfServiceLibrary1.TicketService));
            host.Open();
            Console.WriteLine("Ticket service is started");

            while (true)
            {

            }
        }
    }
}
