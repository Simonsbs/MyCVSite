using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class SocialNetworkRepository : RepositoryBase<SocialNetwork>, ISocialNetworkRepository {
		public SocialNetworkRepository(MainContext _context)
			: base(_context) {
		}
	}
}
