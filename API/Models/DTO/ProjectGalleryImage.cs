namespace MyCVSite.API.Models.DTO {
	public class ProjectGalleryImage {
        public int ID { get; set; }
		public int ProjectID { get; set; }
		public string URL { get; set; }
        public string Alt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }       
    }
}
