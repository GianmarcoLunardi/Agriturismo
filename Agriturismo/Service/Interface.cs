using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Models;

namespace Agriturismo.Service
{

    // Generic Interface
    public interface Irepo<T, in PKey> where T:class
    {
        Task add(T t);
        Task delete(T t);


        Task<T>display(PKey x);
        Task<IEnumerable<T>> displayAll();
        Task<T> Update(T t);

    }


    // Interfa Guests

    public interface IGuests : Irepo<Guest,int> { }


}
