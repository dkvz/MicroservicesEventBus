using Microsoft.AspNetCore.Mvc;

namespace User.API.Controllers;

[ApiController]
[Route("/")]
public class HomeController : Controller
{
  [HttpGet(Name = "/")]
  public IActionResult Index()
  {
    return new RedirectResult("~/swagger");
  }
}
