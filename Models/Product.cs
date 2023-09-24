
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TheCashier.DTOs;

namespace TheCashier.Models;


public class Product
{
    [Key]
    public int Barcode { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public int Category { get; set; }
    [Required]
    public decimal Price { get; set; }
    [Required]
    public decimal Discount { get; set; }

    [AllowNull]
    public string? ImageUrl { get; set; }

    public static Product CreateFromDTO(CreateProductDTO productDTO)
    {
        return new Product
        {
            Name = productDTO.Name,
            Discount = productDTO.Discount,
            Category = productDTO.Category,
            ImageUrl = productDTO.ImageUrl,
            Price = productDTO.Price
        };
    }

}
