using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvenementApi.Models.Entities;

namespace EvenementApi.Data
{
    public class EvenementApiContext : DbContext
    {
        public EvenementApiContext (DbContextOptions<EvenementApiContext> options)
            : base(options)
        {
        }

        public DbSet<EvenementApi.Models.Entities.EvenementDay> EvenementDay { get; set; }
    }
}
