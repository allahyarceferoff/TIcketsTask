using AirplanesTickets.DataAccess.Abstractions;
using AirplanesTickets.DataAccess.DbFirstModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesTickets.DataAccess.Concrete
{
    public class ScheduleRepository : ISchedulesRepository
    {
        public AirplanesDBEntities1 _context { get; set; }

        public ScheduleRepository()
        {
            _context = new AirplanesDBEntities1();
        }
        public void AddData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public void DeleteData(Schedule data)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Schedule> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ObservableCollection<Schedule>> CityGetAll(int id)
        {
            var result = await _context.Schedules.Where(s => s.CityId == id).ToListAsync();
            return new ObservableCollection<Schedule>(result);
        }

        public Schedule GetData(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateData(Schedule data)
        {
            throw new NotImplementedException();
        }
    }
}
