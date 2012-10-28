using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Contact
    {
        public Contact()
        {
            this.ContactIDMembers = new List<Member>();
            this.CreatorIDProjects = new List<Project>();
            this.MaintainerIDProjects = new List<Project>();
            this.FavoritesProjects = new List<Project>();
        }

        public int ContactID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Member> ContactIDMembers { get; set; }
        public virtual ICollection<Project> CreatorIDProjects { get; set; }
        public virtual ICollection<Project> MaintainerIDProjects { get; set; }
        public virtual ICollection<Project> FavoritesProjects { get; set; }
    }
}
