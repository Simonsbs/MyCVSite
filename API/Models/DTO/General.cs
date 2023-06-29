using System.ComponentModel.DataAnnotations;

namespace MyCVSite.API.Models.DTO {
	public class General {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }	
}
