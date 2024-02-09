namespace RentaKranApp.Model
{
    public class TruckCrane
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ModelName { get; set; }
        public string FactoryNumber { get; set; }
        public DateOnly DateOfIssue { get; set; }
        public double Rent { get; set; }
        public int LoadCapacity { get; set; }
        public int BoomLength { get; set; }
        public string Img { get; set; }
    }
}
