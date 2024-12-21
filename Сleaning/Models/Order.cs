namespace Сleaning.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public DateOnly DateOrder { get; set; }

        public DateOnly DateStart {  get; set; }

        public DateOnly DateEnd { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        public ICollection<User> Users  { get; set; } = new List<User>();

        public virtual OrderComposition OrderComposition { get; set; } = null!;
    }
}

