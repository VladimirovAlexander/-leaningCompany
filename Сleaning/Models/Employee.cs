namespace Сleaning.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        public string? Surname { get; set; }

        public string? Name { get; set; }

        public string? Patronymic { get; set; }

        public string? PhoenNumber { get; set; }

        public string? Email { get; set; }

        public string? Position { get; set; }

        public DateOnly DateOfEmployment { get; set; }

        public virtual Order? Order { get; set; }
    }
}
