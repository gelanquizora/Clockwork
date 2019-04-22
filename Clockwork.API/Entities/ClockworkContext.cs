using Microsoft.EntityFrameworkCore;

namespace Clockwork.API.Entities
{
    public class ClockworkContext : DbContext
    {
        public ClockworkContext(DbContextOptions<ClockworkContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<ServerDateTimeRequest> ServerDateTimeRequest { get; set; }
    }
} 