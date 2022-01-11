using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoubleEFContextsTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DoubleEFContextsTest
{
    public class FeatureADbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            bldr.UseSqlServer($"Server=.;Database=FeatureA;User Id=sa;Pwd={System.Environment.GetEnvironmentVariable("SA_PASSWORD")}");
        }

        public DbSet<ModelA> ModelAs { get; set; }
    }
}