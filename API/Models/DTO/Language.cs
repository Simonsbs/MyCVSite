using MyCVSite.API.Models.Enums;

namespace MyCVSite.API.Models.DTO
{
    public class Language {
        public int ID { get; set; }
        public string Name { get; set; }
        public LanguageLevel Level { get; set; }
    }
}
