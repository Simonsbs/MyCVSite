using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models;

namespace MyCVSite.API.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
	public class LoginController : Controller {
		[HttpGet]
		public IActionResult GetToken(LoginInfo loginInfo) {
			
			return Ok();
		}
	}
}
