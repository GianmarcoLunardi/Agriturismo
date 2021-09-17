using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Models;

namespace Agriturismo.Models.interfacce
{
    public interface IGuestRepo : IGenericRepository<Guest,int>
        {

        Task Update(Guest guest);
        }
}
