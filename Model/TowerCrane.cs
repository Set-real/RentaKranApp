namespace RentaKranApp.Model
{
    public class TowerCrane
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ModelName { get; set; }
        public string FactoryNumber { get; set; }
        public DateOnly DateOfIssue { get; set; }
        public double Rent {  get; set; }
        public int LoadCapacity { get; set; }
        public int LoadCapacityAtTheEndOfTheBoom { get; set; }
        public int BoomLength { get; set; }
        public int FreeStandingCraneHeight { get; set; }
        public string Img { get; set; }

        // Один ко многим, у пользователся может быть несколько кранов
        public User User { get; set; }
    }
}
