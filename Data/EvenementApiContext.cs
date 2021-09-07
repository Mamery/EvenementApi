using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EvenementApi.Models.Entities;

namespace EvenementApi.Data
{
    //anropa database
    public class EvenementApiContext : DbContext
    {
        public EvenementApiContext (DbContextOptions<EvenementApiContext> options)
            : base(options)
        {
        }

        public DbSet<EvenementDay> EvenementDays { get; set; }
    }
}
