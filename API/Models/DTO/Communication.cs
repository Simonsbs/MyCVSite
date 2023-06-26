using MyCVSite.API.Models.Enums;

namespace MyCVSite.API.Models.DTO
{
    public class Communication {
        public int ID { get; set; }
        public string From { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Created { get; set; }
        public CommunicationType Type { get; set; }
        public CommunicationStatus Status { get; set; }

    }
}
