using MVC_Exercise.Models;

namespace MVC_Exercise.Data;

public interface IProductRepository
{
    public IEnumerable<Product> GetAllProducts();
    Product GetProduct(int id);
    void UpdateProduct(Product product);
    public void InsertProduct(Product productToInsert);
    public IEnumerable<Category> GetCategories();
    public Product AssignCategory();

    public void DeleteProduct(Product product);
}