
using System;
using EFDoubleMigrationsTest.Contexts.FeatureA;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EFDoubleMigrationsTest {
    public class Program
    {
        public static void Main()
        {
            var dbB = new FeatureBDbContext();
        }
    }

}
