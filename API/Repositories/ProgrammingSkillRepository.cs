using MyCVSite.API.Contexts;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Repositories {
	public class ProgrammingSkillRepository : RepositoryBase<ProgrammingSkill>, IProgrammingSkillRepository {
		public ProgrammingSkillRepository(MainContext _context)
			: base(_context) {
		}
	}
}
