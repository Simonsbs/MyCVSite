using Microsoft.EntityFrameworkCore;
using MyCVSite.API.Models.DTO;
using MyCVSite.API.Models.Enums;

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

			modelBuilder.Entity<User>().HasData(
				new User { ID = 1, Username = "Simon", Password = "1234", Type = UserType.Admin, LastLogin = DateTime.Now }
			);

			modelBuilder.Entity<Project>().HasData(
				new Project { ID = 1, Name = "Mock Project 1", Description = "A mock project", GitURL = "https://github.com/Simonsbs", URL = "https://google.com" },
				new Project { ID = 2, Name = "Mock Project 2", Description = "A mock project", GitURL = "https://github.com/Simonsbs", URL = "https://google.com" }
			);

			modelBuilder.Entity<ProjectGalleryImage>().HasData(
				new ProjectGalleryImage { ID = 1, Title = "Project image #1", Description = "The first image for our project", Alt = "A picture of my project", URL = "https://picsum.photos/id/237/300/300", ProjectID = 1 }
			);

			modelBuilder.Entity<ProgrammingSkill>().HasData(
				new ProgrammingSkill { ID = 1, Name = "C#", KnownFrom = DateTime.Now.AddYears(-1), Category = "Languages" },
				new ProgrammingSkill { ID = 2, Name = "JavaScript", KnownFrom = DateTime.Now.AddYears(-3), Category = "Languages" },
				new ProgrammingSkill { ID = 3, Name = "React", KnownFrom = DateTime.Now.AddYears(-2), Category = "Libraries" }
			);

			modelBuilder.Entity<Project>()
				.HasMany(p => p.Skills)
				.WithMany(s => s.Projects)
				.UsingEntity<Dictionary<int, int>>(
					"ProgrammingSkillProject",
					r => r.HasOne<ProgrammingSkill>().WithMany().HasForeignKey("SkillsID"),
					l => l.HasOne<Project>().WithMany().HasForeignKey("ProjectsID"),
					j => {
						j.HasKey("SkillsID", "ProjectsID");
						j.HasData(
							new { ProjectsID = 1, SkillsID = 1 },
							new { ProjectsID = 1, SkillsID = 2 },
							new { ProjectsID = 1, SkillsID = 3 },
							new { ProjectsID = 2, SkillsID = 2 },
							new { ProjectsID = 2, SkillsID = 3 }
						);
					}
				);
		}
	}
}
