using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class UserRepository : RepositoryBase<User>, IUserRepository {
		public UserRepository(MainContext _context)
			: base(_context) {
		}
	}
}
