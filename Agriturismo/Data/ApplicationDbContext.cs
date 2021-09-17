using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Agriturismo.Models;
using AutoMapper;

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

        public DbSet<Reservation> Reservations { get; set; }

        public DbSet<AutoMapper.AppartamentVM> AppartamentVM { get; set; }

        //public DbSet<Agriturismo.Models.AppartamentVM> AppartamentVM { get; set; }
        



    }
}
