using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class ProjectGalleryImageRepository : RepositoryBase<ProjectGalleryImage>, IProjectGalleryImageRepository {
		public ProjectGalleryImageRepository(MainContext _context)
			: base(_context) {
		}
	}
}
