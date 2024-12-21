namespace Сleaning.Models
{
    public class OrderComposition
    {
        public Guid Id { get; set; }

        public virtual Order Order { get; set; } = null!;

        public virtual Product Product { get; set; } = null!;

    }
}
