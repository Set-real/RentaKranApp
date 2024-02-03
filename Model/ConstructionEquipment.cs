namespace RentaKranApp.Model
{
    public class ConstructionEquipment
    {
        public Guid Id { get; set; }
        public string Model { get; set; }
        public string Appointment { get; set; }
        public string FactoryNumber { get; set; }
        public DateTime CretionDate { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Images { get; set; }
        public string Price { get; set; }

    }
}
