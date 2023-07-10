using MyCVSite.API.Models.DTO;
using MyCVSite.API.Repositories;

namespace MyCVSite.API.Models {
	internal class InitialStateData {
		private InitialStateData() {
		}

		public List<Communication> Communications { get; private set; }
		public List<DTO.Education> Educations { get; private set; }
		public List<Experience> Experiences { get; private set; }
		public List<General> General { get; private set; }
		public List<Hobby> Hobbies { get; private set; }
		public List<Language> Languages { get; private set; }
		public List<PersonalAttribute> PersonalAttributes { get; private set; }
		public List<ProgrammingSkill> ProgrammingSkills { get; private set; }
		public List<Project> Projects { get; private set; }
		public List<SocialNetwork> SocialNetworks { get; private set; }

		internal static InitialStateData Create(
			ICommunicationRepository communicationRepository, 
			IEducationRepository educationRepository, 
			IExperienceRepository experienceRepository, 
			IGeneralRepository generalRepository, 
			IHobbyRepository hobbyRepository, 
			ILanguageRepository languageRepository, 
			IPersonalAttributeRepository personalAttributeRepository, 
			IProgrammingSkillRepository programmingSkillRepository, 
			IProjectRepository projectRepository, 
			ISocialNetworkRepository socialNetworkRepository) {
			
			InitialStateData initialStateData = new InitialStateData();

			initialStateData.Communications = communicationRepository.FindAll().ToList();
			initialStateData.Educations = educationRepository.FindAll().ToList();
			initialStateData.Experiences = experienceRepository.FindAll().ToList();
			initialStateData.General = generalRepository.FindAll().ToList();
			initialStateData.Hobbies = hobbyRepository.FindAll().ToList();
			initialStateData.Languages = languageRepository.FindAll().ToList();
			initialStateData.PersonalAttributes = personalAttributeRepository.FindAll().ToList();
			initialStateData.ProgrammingSkills = programmingSkillRepository.FindAll().ToList();
			initialStateData.Projects = projectRepository.FindAll().ToList();
			initialStateData.SocialNetworks = socialNetworkRepository.FindAll().ToList();

			return initialStateData;
		}
	}
}