using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace MyCVSite.API.Models.DTO {
	public class Project {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ProjectGalleryImage> GalleryImages { get; set; }
        public string URL { get; set; }
		public string GitURL { get; set; }
		public List<ProgrammingSkill> SkillsUsed { get; set; }
    }
}
