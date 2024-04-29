
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductRepository()
        {
            _products = new DatabaseContext().Products;
        }
        public Product CreateOne(Product product)
        {
            Console.WriteLine($"repo {product.Name}");

            _products.Add(product);
            return product;
        }

        public Product? DeleteOne(string productId)
        {
            var deleteProduct = FindOne(productId);

            _products.Remove(deleteProduct!);

            return deleteProduct;
        }



        public List<Product> FindAll()
        {
            return _products;
        }


        public Product? FindOne(string productId)
        {
            var findProduct = _products.Find(product => product.Id == productId);
            return findProduct;
        }

        public Product UpdateOne(Product UpdateProduct)
        {
            var product = _products.Select(product =>
            {
                if (product.Id == UpdateProduct.Id)
                {
                    return UpdateProduct;
                }
                return product;
            });

            _products = product.ToList();
            return UpdateProduct;
        }


namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class ProductRepository
    {
        

    }
}