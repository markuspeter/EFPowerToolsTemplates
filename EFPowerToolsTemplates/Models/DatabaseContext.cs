using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EFT.Models.Mapping;

namespace EFT.Models
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(null);
        }

		public DatabaseContext()
			: base("Name=DatabaseContext")
		{
		}

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new MemberMap());
            modelBuilder.Configurations.Add(new ProjectMap());
        }
    }
}
