namespace RentaKranApp.Model
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UserBirthday { get; set; }

        // Один ко многим, у прльзователя может быть несколько комментариев, кранов или различной техники
        public List<OtherEquipment> OtherEquipments { get; set; }
        public List<TowerCrane> TowerCranes { get; set;}
        public List<TruckCrane> TruckCranes { get; set; }
    }
}
