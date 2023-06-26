using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Controllers {
	[ApiController]
	[Route("api/[controller]")]
	// TODO: only allow users with admin privileges
	public class Users : Controller {
		[HttpGet]
		public IActionResult GetUsers() {
			Users users = new Users();

			return Ok(users);
		}

		[HttpGet]
		public IActionResult GetUser(int id) {

			return Ok();
		}

		[HttpPost]
		public IActionResult AddUser(User user) {

			return Ok();
		}

		[HttpPut]
		public IActionResult UpdateUser(User user) {

			return Ok();
		}

		[HttpDelete]
		public IActionResult DeleteUser(int id) {

			return Ok();
		}
	}
}
