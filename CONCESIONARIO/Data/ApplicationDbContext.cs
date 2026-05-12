using CONCESIONARIO.Models;
using Microsoft.EntityFrameworkCore;

namespace CONCESIONARIO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Cars> Cars { get; set; }

    }
}
