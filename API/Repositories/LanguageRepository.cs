using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class LanguageRepository : RepositoryBase<Language>, ILanguageRepository {
		public LanguageRepository(MainContext _context)
			: base(_context) {
		}
	}
}
