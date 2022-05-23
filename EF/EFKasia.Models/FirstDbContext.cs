using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKasia.Models
{
    public class FirstDbContext : DbContext
    {
        public FirstDbContext(): base(@"CS HERE")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Device> Devices { get; set; }
    }
}
