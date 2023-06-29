using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class CommunicationRepository : RepositoryBase<Communication>, ICommunicationRepository {
		public CommunicationRepository(MainContext _context)
			: base(_context) {
		}
	}
}
