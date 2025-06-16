using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class OrdersController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}