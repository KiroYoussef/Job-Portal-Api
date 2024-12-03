using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EntityModels.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public virtual DbSet<Job> Jobs { get; set;}
        public virtual DbSet<Company> Companies { get; set;}
        public virtual DbSet<Application> Applications { get; set;}
    }
}
