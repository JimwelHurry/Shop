using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class DealsController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}