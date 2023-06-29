namespace MyCVSite.API.Models.DTO {
	public class ProgrammingSkill {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime KnownFrom { get; set; }

		public List<Project> Projects { get; set; }
		public List<Education> Educations { get; set; }
	}
}
