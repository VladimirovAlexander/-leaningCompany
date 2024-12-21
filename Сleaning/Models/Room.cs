namespace Сleaning.Models
{
    public class Room
    {
        public Guid Id { get; set; }

        public string? Country { get; set; }

        public string? Region { get; set; }

        public string? City { get; set; }

        public string? Street { get; set; }

        public int? HouseNumber { get; set; }

        public int? Floor { get; set; }

        public int? ApartmentNumber { get; set; }

        public int? Square { get; set; }

        public string? TypeRoom { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
