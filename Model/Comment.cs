namespace RentaKranApp.Model
{
    public class Comment
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
