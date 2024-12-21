namespace Сleaning.Models
{
    public class OrderComposition
    {
        public Guid Id { get; set; }

        public ICollection<Order> Order { get; set; } = new List<Order>();

        public ICollection<Product> Product { get; set; } = new List<Product>();


    }
}
