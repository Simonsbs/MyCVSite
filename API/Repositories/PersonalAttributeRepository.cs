using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class PersonalAttributeRepository : RepositoryBase<PersonalAttribute>, IPersonalAttributeRepository {
		public PersonalAttributeRepository(MainContext _context)
			: base(_context) {
		}
	}
}
