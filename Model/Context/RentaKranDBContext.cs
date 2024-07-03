using Microsoft.EntityFrameworkCore;

namespace RentaKranApp.Model.Context
{
    public class RentaKranDBContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<OtherEquipment> MyOtherEquipments { get; set; }
        public DbSet<TowerCrane> TowerCranes { get; set; }
        public DbSet<TruckCrane> TruckCranes { get; set; }
        public RentaKranDBContext(DbContextOptions<RentaKranDBContext> options) : base(options)
        {
            Database.EnsureCreated();
            Database.EnsureDeleted();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }
    }
}
