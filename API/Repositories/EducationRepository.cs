using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class EducationRepository : RepositoryBase<Education>, IEducationRepository {
		public EducationRepository(MainContext _context)
			: base(_context) {
		}
	}
}
