using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class GeneralRepository : RepositoryBase<General>, IGeneralRepository {
		public GeneralRepository(MainContext _context)
			: base(_context) {
		}
	}
}
