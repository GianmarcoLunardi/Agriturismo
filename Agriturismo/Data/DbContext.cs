using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agriturismo.Data
{
    public class IdentityAgriContext : IdentityDbContext
    {
        public IdentityAgriContext(DbContextOptions<IdentityAgriContext> options)
            : base(options)
        {
        }

    }

    public class DataAgriContext : DbContext
    {
        public DataAgriContext(DbContextOptions<DataAgriContext> options)
            : base(options)
        {
        }





    }
}
