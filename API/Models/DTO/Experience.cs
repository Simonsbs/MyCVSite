namespace MyCVSite.API.Models.DTO {
	public class Experience {
        public int ID { get; set; }
        public string CompanyName { get; set; }
		public string CompanyURL { get; set; }
		public string CompanyLogoURL { get; set; }
		public string JobTitle { get; set; }
		public string JobDescription { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
    }
}
