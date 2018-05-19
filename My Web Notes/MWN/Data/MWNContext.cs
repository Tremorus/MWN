using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MWN.Models
{
    public class MWNContext : DbContext
    {
        public MWNContext (DbContextOptions<MWNContext> options)
            : base(options)
        {
        }

        public DbSet<MWN.Models.Note> Note { get; set; }
    }
}
