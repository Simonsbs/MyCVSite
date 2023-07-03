using Microsoft.AspNetCore.Mvc;
using MyCVSite.API.Models;
using MyCVSite.API.Repositories;

namespace MyCVSite.API.Controllers
{
    [ApiController]
	[Route("api/[controller]")]
	public class InitialStateController : Controller {
		private readonly IConfiguration _config;
		private readonly ICommunicationRepository communicationRepository;
		private readonly IEducationRepository educationRepository;
		private readonly IExperienceRepository experienceRepository;
		private readonly IGeneralRepository generalRepository;
		private readonly IHobbyRepository hobbyRepository;
		private readonly ILanguageRepository languageRepository;
		private readonly IPersonalAttributeRepository personalAttributeRepository;
		private readonly IProgrammingSkillRepository programmingSkillRepository;
		private readonly IProjectRepository projectRepository;
		private readonly ISocialNetworkRepository socialNetworkRepository;
		private readonly IUserRepository _userRepo;

		public InitialStateController(IConfiguration _config, 
			ICommunicationRepository communicationRepository,
			IEducationRepository educationRepository,
			IExperienceRepository experienceRepository,
			IGeneralRepository generalRepository,
			IHobbyRepository hobbyRepository,
			ILanguageRepository languageRepository,
			IPersonalAttributeRepository personalAttributeRepository,
			IProgrammingSkillRepository programmingSkillRepository,
			IProjectRepository projectRepository,
			ISocialNetworkRepository socialNetworkRepository
			) {
			this._config = _config ?? throw new ArgumentNullException(nameof(_config));
			this.communicationRepository = communicationRepository ?? throw new ArgumentNullException(nameof(communicationRepository));
			this.educationRepository = educationRepository;
			this.experienceRepository = experienceRepository;
			this.generalRepository = generalRepository;
			this.hobbyRepository = hobbyRepository;
			this.languageRepository = languageRepository;
			this.personalAttributeRepository = personalAttributeRepository;
			this.programmingSkillRepository = programmingSkillRepository;
			this.projectRepository = projectRepository;
			this.socialNetworkRepository = socialNetworkRepository;
		}


		[HttpGet]
		public IActionResult GetAll() {
			InitialStateData result = InitialStateData.Create(
				communicationRepository,
				educationRepository,
				experienceRepository,
				generalRepository,
				hobbyRepository,
				languageRepository,
				personalAttributeRepository,
				programmingSkillRepository,
				projectRepository,
				socialNetworkRepository
			);


			return Ok(result);
		}
	}
}
