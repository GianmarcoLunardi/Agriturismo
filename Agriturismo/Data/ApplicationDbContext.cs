using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Agriturismo.Models;

namespace Agriturismo.Data
{
    public class IdentityAgriContext : IdentityDbContext
    {
        public IdentityAgriContext(DbContextOptions<IdentityAgriContext> options)
            : base(options)
        {
        }
    }


    //DataAgriContext

    public class DataAgriContext : DbContext
    {
        public DataAgriContext(DbContextOptions<DataAgriContext> options)
            : base(options)
        {
        }

        public DbSet<Guest> Guests { get; set; }
        public DbSet<Appartament> Appartaments { get; set; }
        
    }
}
