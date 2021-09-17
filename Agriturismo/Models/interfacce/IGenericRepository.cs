using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agriturismo.Models.interfacce
    {


            public interface IGenericRepository<T, Tkey> where T : class
            {
                Task Add(T t);
                Task<T> Get(Tkey i);
                Task Delete(T t);
                Task<IEnumerable<T>> All();
        
            };
   
}
