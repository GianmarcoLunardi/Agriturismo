using Agriturismo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriturismo.Service
{
    public class GuestService : IGuests
    {
        private readonly IGuests GuestContext;
        public GuestService(IGuests g)
        {
            GuestContext = g;
        }
        
        public Task add(Guest t)
        {
            throw new NotImplementedException();
        }

        public Task delete(Guest t)
        {
            throw new NotImplementedException();
        }

        public Task<Guest> display(int x)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Guest>> displayAll()
        {
            throw new NotImplementedException();
        }

        public Task<Guest> Update(Guest t)
        {
            throw new NotImplementedException();
        }
    }
}
