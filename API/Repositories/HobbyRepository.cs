using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class HobbyRepository : RepositoryBase<Hobby>, IHobbyRepository {
		public HobbyRepository(MainContext _context)
			: base(_context) {
		}
	}
}
