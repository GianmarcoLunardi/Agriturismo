using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agriturismo.Models;
using Agriturismo.Data;
using Microsoft.EntityFrameworkCore;

namespace Agriturismo.Service
{

    // Generic Interface
    public interface Irepo<T,  PKey> where T : class
    {
        Task<T> Get(PKey i);
        Task<IEnumerable<T>> GetAll();
        Task add(T t);
        Task delete(T t);
        Task Update(T t);

    }
    // Genic Class
    public class GenericRepoIrepo<T, PKey> : Irepo<T, PKey> where T : class
    {
        protected DataAgriContext context;

        public GenericRepoIrepo(DataAgriContext c)
        {
            this.context = c;
        }

        async Task add(T t)
        {
             await context.Set<T>().AddAsync(t);
            await context.SaveChangesAsync();
    }

        Task Irepo<T, PKey>.add(T t)
        {
            throw new NotImplementedException();
        }

        async Task delete(T t)
        {
            context.Set<T>().Remove(t);
            await context.SaveChangesAsync();
    }

        Task Irepo<T, PKey>.delete(T t)
        {
            throw new NotImplementedException();
        }

        async Task<T> Get(PKey i)
        {
            return await context.Set<T>().FindAsync(i);
                
                
        }

        Task<T> Irepo<T, PKey>.Get(PKey i)
        {
            throw new NotImplementedException();
        }

        async Task<IEnumerable<T>> GetAll()
        {
            return context.Set<T>();
        }

        Task<IEnumerable<T>> Irepo<T, PKey>.GetAll()
        {
            throw new NotImplementedException();
        }

        async Task Update(T t)
        {
             context.Set<T>().Update(t);
        }

        Task Irepo<T, PKey>.Update(T t)
        {
            throw new NotImplementedException();
        }
    }



    // Interfa Guests

    public interface IGuests : Irepo<Guest, int> { }

    public interface IAppartamtsService : Irepo<Appartament, int> { }
 




}
