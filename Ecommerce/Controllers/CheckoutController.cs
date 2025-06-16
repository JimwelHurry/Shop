using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class CheckoutController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  }
