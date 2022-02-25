namespace SportsStore.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>()
        {
            new Product { Id = 1, Name = "Footbal", Price = 20},
            new Product { Id = 2, Name = "Surf board", Price = 12},
            new Product { Id = 3, Name = "Running shoes", Price = 23}
        }.AsQueryable<Product>();
    }
}
