using DAL.Models;
using DAL.Repositories;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketRepository repo = new TicketRepository();
            //Ticket ticket = new Ticket();
            //ticket.Number = 6;

            //repo.Create(ticket);
            var list = repo.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
