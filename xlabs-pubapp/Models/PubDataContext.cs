using Microsoft.EntityFrameworkCore;

namespace xlabs_pubapp.Models
{
    public class PubDataContext : DbContext
    {
        public PubDataContext(DbContextOptions<PubDataContext> options) : base(options) 
        { 
        }

        public DbSet<PubDetail> Details { get; set; }

    }
}
