using AirplanesTickets.DataAccess.DbFirstModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirplanesTickets.DataAccess.Abstractions
{
    public interface ISchedulesRepository : IRepository<Schedule>
    {
    }
}
