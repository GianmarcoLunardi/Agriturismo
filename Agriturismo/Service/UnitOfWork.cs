using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Data;
using Agriturismo.Models;
using Agriturismo.Models.interfacce;

namespace Agriturismo.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGenericRepository<Guest, int> _GuestTable;
        private IGenericRepository<Scheduler, int> _SchedulerTable;
        private IGenericRepository<Reservation, int> _ReservationTable;



        public IGenericRepository<Guest, int> GuestTable => _GuestTable ??= new GenericRepository<Guest, int>(_AgriContext);

        public IGenericRepository<Scheduler, int> SchedulerTable => _SchedulerTable ??= new GenericRepository<Scheduler, int>(_AgriContext);

        public IGenericRepository<Reservation, int> ReservationTable => _ReservationTable ??= new GenericRepository<Reservation, int>(_AgriContext);

        private readonly DataAgriContext _AgriContext;


        public UnitOfWork(DataAgriContext c)
            {
            this._AgriContext = c;
            }


        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}
