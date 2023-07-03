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
    public class AirplaneRepository : IAirplanesRepository
    {
        public AirplanesDBEntities1 _context { get; set; }

        public AirplaneRepository()
        {
            _context = new AirplanesDBEntities1();
        }
        public void AddData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Airplane data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Airplane> GetAll()
        {
            var result=from a in _context.Airplanes
                       orderby a.Model
                       select a;
            return new ObservableCollection<Airplane>(result);
        }

        public Airplane GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Airplane data)
        {
            throw new NotImplementedException();
        }
    }
}
