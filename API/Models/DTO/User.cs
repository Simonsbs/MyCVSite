using MyCVSite.API.Models.Enums;

namespace MyCVSite.API.Models.DTO
{
    public class User {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserType Type { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
