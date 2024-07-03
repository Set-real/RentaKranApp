namespace RentaKranApp.Model
{
    public class Administrator
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string JobTitle { get; set; }
        public string Password { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
