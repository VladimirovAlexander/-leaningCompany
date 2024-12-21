namespace Сleaning.Models
{
    public class Client
    {
        public Guid Id { get; set; }

        public string? Surname { get; set; }

        public string? Name { get; set; }

        public string? Patronymic { get; set; }

        public string? PhoenNumber { get; set; }

        public string? Email { get; set; }

        public virtual Order Order { get; set; } = null!;
    }
}
