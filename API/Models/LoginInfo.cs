using System.ComponentModel.DataAnnotations;

namespace MyCVSite.API.Models {
	public class LoginInfo {
        [Required]
        public string Username { get; set; } = string.Empty;
		[Required]
		public string Password { get; set; } = string.Empty;
	}
}