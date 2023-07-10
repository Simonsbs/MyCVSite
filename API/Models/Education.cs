namespace MyCVSite.API.Models {
	public class Education {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Ended { get; set; }
        public string Description { get; set; }
        public List<int> Skills { get; set; }
    }
}
