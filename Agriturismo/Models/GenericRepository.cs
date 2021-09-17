using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Models.interfacce;
using Agriturismo.Data;
using Microsoft.EntityFrameworkCore;

namespace Agriturismo.Models
{
    public class GenericRepository<T, Tkey> : IGenericRepository<T, Tkey> where T : class
    {
        readonly protected DataAgriContext context;
        internal DbSet<T> DbSet;

        public GenericRepository(DataAgriContext context)
        {
            this.context = context;
            DbSet = context.Set<T>();
        }

        async Task IGenericRepository<T, Tkey>.Add(T t)
        {
            DbSet.AddAsync(t);
        }

        async Task<IEnumerable<T>> IGenericRepository<T, Tkey>.All()
        {
            return DbSet;
        }

        async Task IGenericRepository<T, Tkey>.Delete(T t)
        {
            DbSet.Remove(t);
        }

        async  Task<T>   IGenericRepository<T, Tkey>.Get(Tkey i)
        {
            return await DbSet.FindAsync(i);

        }
    }
}
