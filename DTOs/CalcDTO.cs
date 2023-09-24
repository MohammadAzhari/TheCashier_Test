namespace TheCashier.DTOs;

public record CalculationsInputItem(CreateProductDTO ProductDTO, int Qty);

public record CalculationsOutput(decimal Sum, decimal Discount, decimal DeliveryAmount, decimal Tax, decimal TotalAmount);
