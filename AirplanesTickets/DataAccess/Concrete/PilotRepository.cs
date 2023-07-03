using AirplanesTickets.DataAccess.Abstractions;
using AirplanesTickets.DataAccess.DbFirstModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesTickets.DataAccess.Concrete
{
    public class PilotRepository : IPilotRepository
    {
        public AirplanesDBEntities1 _context { get; set; }

        public PilotRepository()
        {
            _context = new AirplanesDBEntities1();
        }
        public void AddData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Pilot data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Pilot> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pilot GetData(int id)
        {
            var result=_context.Pilots.SingleOrDefault(p => p.Id == id);
            return result;
        }

        public void UpdateData(Pilot data)
        {
            throw new NotImplementedException();
        }
    }
}
