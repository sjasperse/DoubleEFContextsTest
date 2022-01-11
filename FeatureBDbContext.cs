using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFDoubleMigrationsTest.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDoubleMigrationsTest
{
    public class FeatureBDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder bldr)
        {
            bldr.UseSqlServer($"Server=.;Database=FeatureB;User Id=sa;Pwd={System.Environment.GetEnvironmentVariable("SA_PASSWORD")}");
        }
        
        public DbSet<ModelB> ModelBs { get; set; }
    }
}