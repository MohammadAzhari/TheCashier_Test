using System;
using System.Collections.Generic;
using TheCashier.DTOs;
using TheCashier.Models;

namespace TheCashier.Repos;

public class ProductRepo : IProductRepo
{
    private readonly TheCashierContext _context;

    public ProductRepo(TheCashierContext context)
    {
        _context = context;
    }

    public Product CreateProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();

        return product;
    }

    public void DeleteProduct(int barcode)
    {

        var product = _context.Products.Find(barcode);
        if (product != null)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }

    public Product? GetProductByBarcode(int barcode)
    {

        var product = _context.Products.Find(barcode);
        return product;
    }

    public IEnumerable<Product> GetProducts(string? name, int? category)
    {

        var query = _context.Products.AsQueryable();

        if (!string.IsNullOrEmpty(name))
        {
            query = query.Where(p => p.Name.Contains(name));
        }

        if (category.HasValue)
        {
            query = query.Where(p => p.Category == category.Value);
        }

        return query.ToList();
    }

    public Product UpdateProduct(int barcode, UpdateProductDTO product)
    {

        var existingProduct = GetProductByBarcode(barcode);
        if (existingProduct != null)
        {
            // Update the properties of the existing product with the new values if they are provided
            if (product.Name is not null)
            {
                existingProduct.Name = product.Name;
            }

            if (product.Category is not null)
            {
                existingProduct.Category = (int)product.Category;
            }

            if (product.Discount is not null)
            {
                existingProduct.Discount = (int)product.Discount;
            }

            if (product.Price is not null)
            {
                existingProduct.Price = (int)product.Price;
            }

            if (product.ImageUrl is not null)
            {
                existingProduct.ImageUrl = product.ImageUrl;
            }


            _context.SaveChanges();
        }

        return existingProduct;
    }
}
