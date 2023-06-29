using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class ProjectRepository : RepositoryBase<Project>, IProjectRepository {
		public ProjectRepository(MainContext _context)
			: base(_context) {
		}
	}
}
