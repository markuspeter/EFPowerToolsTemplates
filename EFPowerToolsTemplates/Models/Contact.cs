using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Contact
    {
        public Contact()
        {
            this.ContactMembers = new List<Member>();
            this.CreatorProjects = new List<Project>();
            this.MaintainerProjects = new List<Project>();
            this.FavoritesProjects = new List<Project>();
        }

        public int ContactID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Member> ContactMembers { get; set; }
        public virtual ICollection<Project> CreatorProjects { get; set; }
        public virtual ICollection<Project> MaintainerProjects { get; set; }
        public virtual ICollection<Project> FavoritesProjects { get; set; }
    }
}
