using Microsoft.EntityFrameworkCore;

namespace RentaKranApp.Model.Context
{
    public class RentaKranDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<OtherEquipment> OtherEquipments { get; set; }
        public DbSet<TowerCrane> TowerCranes { get; set; }
        public DbSet<TruckCrane> TruckCranes { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public RentaKranDBContext(DbContextOptions<RentaKranDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
