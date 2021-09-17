using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriturismo.Models.interfacce
{
    public interface IUnitOfWork : IDisposable  
    {

        IGenericRepository<Guest,int> GuestTable { get; }
        IGenericRepository<Scheduler, int> SchedulerTable { get; }
        IGenericRepository<Reservation, int> ReservationTable { get; }


        Task Save();

    }
}
