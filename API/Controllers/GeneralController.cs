using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models.DTO;
using MyCVSite.API.Repositories;

namespace MyCVSite.API.Controllers {
	[ApiController]
	[Route("api/[controller]")]
	public class GeneralController : Controller {
		private readonly IGeneralRepository _repo;

		public GeneralController(IGeneralRepository _repo) {
			this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
		}

		[HttpGet]
		public IActionResult GetAll() {
			var result = _repo.FindAll().ToList();
			return Ok(result);
		}

		[HttpPost]
		public IActionResult Create(General item) {
			if (item == null) {
				return BadRequest();
			}

			var result = _repo.Create(item);

			return Created("user", result);
		}

		[HttpPut]
		public IActionResult Update(General item) {
			if (item == null) {
				return BadRequest();
			}

			var exists = _repo.FindByCondition(u => u.Key == item.Key).Any();
			if (!exists) {
				return NotFound();
			}

			_repo.Update(item);

			return NoContent();
		}

		[HttpDelete("{key}")]
		public IActionResult Delete(string key) {
			var user = _repo.FindByCondition(u => u.Key == key).FirstOrDefault();
			if (user == null) {
				return NotFound();
			}

			_repo.Delete(user);
			return NoContent();
		}
	}
}
