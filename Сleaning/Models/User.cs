using Microsoft.AspNetCore.Identity;

namespace Сleaning.Models
{
    public class User: IdentityUser
    {
        public Guid Id { get; set; }

        public string? Surname { get; set; }

        public string? Name { get; set; }

        public string? Patronymic { get; set; }

        public string? PhoenNumber { get; set; }

        public string? Email { get; set; }

        public virtual Order Order { get; set; } = null!;

        public ICollection<Room> Room { get; set; } = new List<Room>();
    }
}
