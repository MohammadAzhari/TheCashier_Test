using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using TheCashier.Constants;
using TheCashier.DTOs;
using TheCashier.Repos;

namespace TheCashier.Controllers;


[ApiController]
[Route("api/calculations")]
public class CalculationsController : ControllerBase
{

    private readonly IProductRepo _repo;

    public CalculationsController(IProductRepo repo)
    {
        _repo = repo;
    }

    [HttpPost]
    public ActionResult<CalculationsOutput> Post(IEnumerable<CalculationsInputItem> calculationsInput)
    {
        decimal Sum = 0;
        foreach (var calculationsInputItem in calculationsInput)
        {
            Sum += calculationsInputItem.ProductDTO.Price * calculationsInputItem.Qty;
        }
        decimal Discount = Sum * CalcConstants.GeneralDiscountPercent;
        decimal DeliveryAmount = CalcConstants.DeliveryAmount;
        decimal TotalAmount = Sum - Discount + DeliveryAmount;
        decimal Tax = TotalAmount * CalcConstants.TaxPercent;

        TotalAmount += Tax;

        var output = new CalculationsOutput(Sum, Discount, DeliveryAmount, Tax, TotalAmount);

        return Ok(output);
    }
}

