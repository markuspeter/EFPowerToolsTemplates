using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFT.Models.Mapping
{
    public class MemberMap : EntityTypeConfiguration<Member>
    {
        public MemberMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ContactID, t.ProjectID });

            // Properties
            this.Property(t => t.ContactID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ProjectID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Members");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.JoinedOn).HasColumnName("JoinedOn");

            // Relationships
            this.HasRequired(t => t.ContactContact)
                .WithMany(t => t.ContactMembers)
                .HasForeignKey(d => d.ContactID);
            this.HasRequired(t => t.ProjectProject)
                .WithMany(t => t.ProjectMembers)
                .HasForeignKey(d => d.ProjectID);

        }
    }
}
