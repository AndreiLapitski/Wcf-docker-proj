using System.Data.Entity;

namespace DAL.Models
{
    class Ticket_DbContext : DbContext
    {
        public Ticket_DbContext():base("DbConnection") { }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
