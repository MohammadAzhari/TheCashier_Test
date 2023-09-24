using TheCashier.DTOs;
using TheCashier.Models;

namespace TheCashier.Repos;
public interface IProductRepo
{
    public Product CreateProduct(Product product);

    public IEnumerable<Product> GetProducts(string? name, int? category);

    public Product? GetProductByBarcode(int barcode);

    public Product UpdateProduct(int barcode, UpdateProductDTO product);

    public void DeleteProduct(int barcode);
}
