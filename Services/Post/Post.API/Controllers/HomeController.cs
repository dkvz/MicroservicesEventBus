using Microsoft.AspNetCore.Mvc;

namespace Post.API.Controllers;

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
