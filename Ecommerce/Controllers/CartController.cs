using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class CartController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}