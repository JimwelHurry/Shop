using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class ProductsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Details(string id)
  {
    // Allow IDs 1 to 8 and also 101 to 108
    var allowedIds = new[]
    {
        "1", "2", "3", "4", "5", "6", "7", "8",
        "101", "102", "103", "104"
    };

    if (!allowedIds.Contains(id))
    {
      return NotFound();
    }

    return View($"Details/{id}");
  }
 
}