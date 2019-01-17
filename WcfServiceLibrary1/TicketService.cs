using System.Collections.Generic;
using DAL.Models;
using DAL.Repositories;

namespace WcfServiceLibrary1
{
    public class TicketService : ITicketService
    {
        public int Create(Ticket ticket)
        {
            TicketRepository repository = new TicketRepository();
            return repository.Create(ticket);            
        }

        public void Delete(int id)
        {
            TicketRepository repository = new TicketRepository();
            repository.Delete(id);
        }

        public IEnumerable<Ticket> GetAll()
        {
            TicketRepository repository = new TicketRepository();
            return repository.GetAll();
        }

        public string GetYourString(string str)
        {
            return str;
        }

        public void Update(Ticket ticket)
        {
            TicketRepository repository = new TicketRepository();
            repository.Update(ticket);
        }
    }
}
