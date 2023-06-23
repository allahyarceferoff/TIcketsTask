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
    public class CityRepository : ICityRepository
    {
        public AirplanesDBEntities _context { get; set; }

        public CityRepository()
        {
            _context = new AirplanesDBEntities();
        }
        public void AddData(City data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(City data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<City> GetAll()
        {
            var result = from c in _context.Cities
                         orderby c.Name
                         select c;
            return new ObservableCollection<City>(result);
        }

        public City GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(City data)
        {
            throw new NotImplementedException();
        }
    }
}
