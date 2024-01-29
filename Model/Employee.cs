namespace RentaKranApp.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EmployeeBirthday { get; set; }
        public string JobTitle { get; set; }
        public int Salary { get; set; }
    }
}
