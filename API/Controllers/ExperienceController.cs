using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models.DTO;
using MyCVSite.API.Repositories;

namespace MyCVSite.API.Controllers {
	[ApiController]
	[Route("api/[controller]")]
	public class ExperienceController : Controller {
		private readonly IExperienceRepository _repo;

		public ExperienceController(IExperienceRepository _repo) {
			this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
		}

		[HttpGet]
		public IActionResult GetAll() {
			var result = _repo.FindAll().ToList();
			return Ok(result);
		}

		[HttpGet("{id:int}")]
		public IActionResult GetByID(int id) {
			var result = _repo.FindByCondition(u => u.ID == id).FirstOrDefault();
			return Ok(result);
		}

		[HttpPost]
		public IActionResult Create(Experience item) {
			if (item == null) {
				return BadRequest();
			}

			var result = _repo.Create(item);

			return Created("user", result);
		}

		[HttpPut]
		public IActionResult Update(Experience item) {
			if (item == null) {
				return BadRequest();
			}

			var exists = _repo.FindByCondition(u => u.ID == item.ID).Any();
			if (!exists) {
				return NotFound();
			}

			_repo.Update(item);

			return NoContent();
		}

		[HttpDelete("{id:int}")]
		public IActionResult Delete(int id) {
			var user = _repo.FindByCondition(u => u.ID == id).FirstOrDefault();
			if (user == null) {
				return NotFound();
			}

			_repo.Delete(user);
			return NoContent();
		}
	}
}
