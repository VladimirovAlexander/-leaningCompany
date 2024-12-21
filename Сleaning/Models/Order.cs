namespace Сleaning.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public virtual Employee Employee { get; set; } = null!;

        public virtual Client Client { get; set; } = null!;

        public DateOnly DateOrder { get; set; }

        public DateOnly DateStart {  get; set; }

        public DateOnly DateEnd { get; set; }

        public ICollection<OrderComposition> orderCompositions { get; set; } = new List<OrderComposition>
    }
}
