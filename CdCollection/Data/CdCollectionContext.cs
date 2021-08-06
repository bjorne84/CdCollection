using CdCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CdCollection.Data
{
    public class CdCollectionContext : DbContext
    {
        public CdCollectionContext(DbContextOptions<CdCollectionContext>options) :base(options)
        {

        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cd> Cds { get; set; }


    }
}
