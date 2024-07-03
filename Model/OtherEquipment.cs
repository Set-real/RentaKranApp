namespace RentaKranApp.Model
{
    public class OtherEquipment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ModelName { get; set; }
        public string FactoryNumber { get; set; }
        public DateOnly DateOfIssue { get; set; }
        public double Rent { get; set; }
        public int LoadCapacity { get; set; }
        public int EnginePower { get; set; }
        public string Img { get; set; }

        // Одни ко многим, у пользователя может быть много различной техники
        public User User { get; set; }
    }
}
