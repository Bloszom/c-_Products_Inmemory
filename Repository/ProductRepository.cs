using InMemory.Models;

namespace InMemory.Repository
{
    public class ProductRepository
    {
        private List<Products> products;

        public ProductRepository()
        {
            // Initialize with some dummy data
            products = new List<Products>
            {
                new Products { Id = 1, Name = "Product 1", Price = 10.99m },
                new Products { Id = 2, Name = "Product 2", Price = 20.49m },
                new Products { Id = 3, Name = "Product 3", Price = 15.99m }
            };
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return products;
        }

        public Products GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }

}
