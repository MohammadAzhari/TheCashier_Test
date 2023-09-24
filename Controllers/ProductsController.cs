using Microsoft.AspNetCore.Mvc;
using TheCashier.DTOs;
using TheCashier.Models;
using TheCashier.Repos;

namespace TheCashier.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{

    private readonly IProductRepo _repo;

    public ProductsController(IProductRepo repo)
    {
        _repo = repo;
    }

    [HttpGet]
    public IEnumerable<Product> Get(string? name, int? category)
    {
        return _repo.GetProducts(name, category);
    }

    [HttpGet("{barcode}")]
    public ActionResult<Product> GetByBarcode(int barcode)
    {
        var product = _repo.GetProductByBarcode(barcode);
        if (product is null)
        {
            return NotFound();
        }
        return Ok(product);
    }

    [HttpPost]
    public Product Post(CreateProductDTO productDTO)
    {
        var product = Product.CreateFromDTO(productDTO);
        return _repo.CreateProduct(product);
    }

    [HttpPut("{barcode}")]
    public ActionResult<Product> Put(int barcode, UpdateProductDTO productDTO)
    {

        if (IsProductNotFound(barcode))
        {
            return NotFound();
        }

        var product = _repo.UpdateProduct(barcode, productDTO);
        return Ok(product);
    }

    [HttpDelete("{barcode}")]
    public IActionResult Delete(int barcode)
    {

        if (IsProductNotFound(barcode))
        {
            return NotFound();
        }

        _repo.DeleteProduct(barcode);
        return NoContent();
    }

    private bool IsProductNotFound(int barcode) => _repo.GetProductByBarcode(barcode) is null;
}