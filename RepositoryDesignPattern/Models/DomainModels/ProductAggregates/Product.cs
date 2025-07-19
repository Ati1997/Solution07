namespace RepositoryDesignPattern.Models.DomainModels.ProductAggregates
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
    }
}
