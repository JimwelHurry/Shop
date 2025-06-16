using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Ecommerce.Controllers;

public class ProfileController : Controller
{
  public IActionResult Index()
  {
    return View();
  }
}