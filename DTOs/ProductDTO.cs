namespace TheCashier.DTOs;


public record CreateProductDTO(string Name, int Category, decimal Price, decimal Discount, string? ImageUrl);

public record UpdateProductDTO(string? Name, int? Category, decimal? Price, decimal? Discount, string? ImageUrl);
