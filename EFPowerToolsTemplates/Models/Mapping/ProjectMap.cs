using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EFT.Models.Mapping
{
    public class ProjectMap : EntityTypeConfiguration<Project>
    {
        public ProjectMap()
        {
            // Primary Key
            this.HasKey(t => t.ProjectID);

            // Properties
            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Projects");
            this.Property(t => t.ProjectID).HasColumnName("ProjectID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.CreatorID).HasColumnName("CreatorID");
            this.Property(t => t.MaintainerID).HasColumnName("MaintainerID");

            // Relationships
            this.HasRequired(t => t.CreatorIDContact)
                .WithMany(t => t.CreatorIDProjects)
                .HasForeignKey(d => d.CreatorID);
            this.HasOptional(t => t.MaintainerIDContact)
                .WithMany(t => t.MaintainerIDProjects)
                .HasForeignKey(d => d.MaintainerID);

        }
    }
}
