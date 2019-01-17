using System.Collections.Generic;
using DAL.Interaces;
using DAL.Models;
using System.Linq;

namespace DAL.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        public int Create(Ticket obj)
        {
            using (Ticket_DbContext context = new Ticket_DbContext())
            {
                context.Tickets.Add(obj);
                context.SaveChanges();

                return obj.Id;
            }
        }

        public void Delete(int id)
        {
            using (Ticket_DbContext context = new Ticket_DbContext())
            {
                context.Tickets.Remove(context.Tickets.Find(id));
                context.SaveChanges();
            }
        }

        public IEnumerable<Ticket> GetAll()
        {
            using (Ticket_DbContext context = new Ticket_DbContext())
            {
                return context.Tickets.AsNoTracking().ToList();
            }
        }

        public Ticket GetById(int id)
        {
            using (Ticket_DbContext context = new Ticket_DbContext())
            {
                return context.Tickets.AsNoTracking().FirstOrDefault(t => t.Id == id);
            }
        }

        public void Update(Ticket obj)
        {
            using (Ticket_DbContext context = new Ticket_DbContext())
            {
                Ticket old_ticket = context.Tickets.Find(obj.Id);
                old_ticket.EventName = obj.EventName;
                old_ticket.Price = obj.Price;
                context.SaveChanges();
            }
        }
    }
}
