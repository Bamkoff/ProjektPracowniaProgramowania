using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MojaApka.Models
{
    public class MojaApkaContext : DbContext
    {
        public MojaApkaContext (DbContextOptions<MojaApkaContext> options)
            : base(options)
        {
        }

        public DbSet<MojaApka.Models.User> User { get; set; }
    }
}
