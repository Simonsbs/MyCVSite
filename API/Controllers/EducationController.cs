using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models;
using MyCVSite.API.Models.DTO;
using MyCVSite.API.Repositories;

namespace MyCVSite.API.Controllers {
	[ApiController]
	[Route("api/[controller]")]
	public class EducationController : Controller {
		private readonly IEducationRepository _repo;
		private readonly IProgrammingSkillRepository _repoSkills;

		public EducationController(IEducationRepository _repo, IProgrammingSkillRepository _repoSkills) {
			this._repo = _repo ?? throw new ArgumentNullException(nameof(_repo));
			this._repoSkills = _repoSkills ?? throw new ArgumentNullException(nameof(_repoSkills));
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
		public IActionResult Create(Models.Education item) {
			if (item == null) {
				return BadRequest();
			}

			List<ProgrammingSkill> skills = new List<ProgrammingSkill>();
			foreach (int skillID in item.Skills) {
				var skill = _repoSkills.FindByCondition(s => s.ID == skillID).FirstOrDefault();
				if (skill == null) {
					continue;
				}
				skills.Add(skill);
			}

			var newItem = new Models.DTO.Education() {
				ID = item.ID,
				Description = item.Description,
				Ended = item.Ended,
				Name = item.Name,
				Started = item.Started,
				Skills = skills,
			};

			var result = _repo.Create(newItem);

			return Created("user", result);
		}

		[HttpPut]
		public IActionResult Update(Models.Education item) {
			if (item == null) {
				return BadRequest();
			}

			var current = _repo.FindByCondition(u => u.ID == item.ID).FirstOrDefault();
			if (current == null) {
				return NotFound();
			}

			current.Started = item.Started;
			current.Name = item.Name;
			current.Description = item.Description;
			current.Ended = item.Ended;
			current.Skills = new List<ProgrammingSkill>();

			foreach (int skillID in item.Skills) {
				if (current.Skills.Any(s => s.ID == skillID)) {
					continue;
				}
				var newSkill = _repoSkills.FindByCondition(s => s.ID == skillID).FirstOrDefault();
				if (newSkill == null) {
					continue;
				}
				current.Skills.Add(newSkill);
			}

			List<ProgrammingSkill> skillsToRemove = new List<ProgrammingSkill>();
			foreach (var skill in current.Skills) {
				if (item.Skills.Contains(skill.ID)) {
					continue;
				}
				skillsToRemove.Add(skill);
			}
			foreach (var skill in skillsToRemove) {
				current.Skills.Remove(skill);
			}

			_repo.Update(current);

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
