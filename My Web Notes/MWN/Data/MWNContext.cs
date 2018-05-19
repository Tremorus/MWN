using Microsoft.EntityFrameworkCore;

namespace MWN.Models
{
    public class MWNContext : DbContext
    {
        public MWNContext (DbContextOptions<MWNContext> options)
            : base(options)
        {
        }

        public DbSet<Note> Note { get; set; }
    }
}
