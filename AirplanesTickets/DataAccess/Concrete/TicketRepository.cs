using AirplanesTickets.DataAccess.Abstractions;
using AirplanesTickets.DataAccess.DbFirstModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AirplanesTickets.DataAccess.Concrete
{
    public class TicketRepository : ITicketsRepository
    {
        public AirplanesDBEntities1 _context { get; set; }

        public TicketRepository()
        {
            _context = new AirplanesDBEntities1();
        }
        public void AddData(Ticket data)
        {
            _context.Entry(data).State= EntityState.Added;
            _context.SaveChanges();
        }

        public void DeleteData(Ticket data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Ticket> GetAll()
        {
            throw new NotImplementedException();
        }

        public Ticket GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Ticket data)
        {
            throw new NotImplementedException();
        }
    }
}
