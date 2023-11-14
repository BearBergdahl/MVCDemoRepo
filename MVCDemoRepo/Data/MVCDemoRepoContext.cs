using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCDemoRepo.Models;

namespace MVCDemoRepo.Data
{
    public class MVCDemoRepoContext : DbContext
    {
        public MVCDemoRepoContext (DbContextOptions<MVCDemoRepoContext> options)
            : base(options)
        {
        }

        public DbSet<MVCDemoRepo.Models.Department> Department { get; set; } = default!;
    }
}
