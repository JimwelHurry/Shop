using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class AccountController : Controller
{
  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Profile()
  {
    return View();
  }
  
}