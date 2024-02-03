using Microsoft.EntityFrameworkCore;

namespace RentaKranApp.Model.Context
{
    public class AppContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<ConstructionEquipment> ConstructionEquipment { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
