
using System;
using Microsoft.EntityFrameworkCore;

namespace DoubleEFContextsTest {
    public class Program
    {
        public static void Main()
        {
            // no EF setup here. For simplicity of the demo, connstrs are configured in the "OnConfiguring" method on the DbContexts themselves
        }
    }
}
