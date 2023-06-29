using Microsoft.EntityFrameworkCore;
using MyCVSite.API.Models.DTO;

namespace MyCVSite.API.Contexts {
	public class MainContext : DbContext {
		public MainContext(DbContextOptions<MainContext> _options) 
			: base(_options) {
		}

		public DbSet<Communication> Communications { get; set; }
		public DbSet<Education> Educations { get; set; }
		public DbSet<Experience> Experiences { get; set; }
		public DbSet<General> Generals { get; set; }
		public DbSet<Hobby> Hobbies { get; set; }
		public DbSet<Language> Languages { get; set; }
		public DbSet<PersonalAttribute> PersonalAttributes { get; set; }
		public DbSet<ProgrammingSkill> ProgrammingSkills { get; set; }
		public DbSet<Project> Projects { get; set; }
		public DbSet<ProjectGalleryImage> ProjectGalleryImages { get; set; }
		public DbSet<SocialNetwork> SocialNetworks { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
		}
	}
}
