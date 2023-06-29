using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class ExperienceRepository : RepositoryBase<Experience>, IExperienceRepository {
		public ExperienceRepository(MainContext _context)
			: base(_context) {
		}
	}
}
