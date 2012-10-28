using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Project
    {
        public Project()
        {
            this.ProjectMembers = new List<Member>();
            this.FavoritesContacts = new List<Contact>();
        }

        public int ProjectID { get; set; }
        public string Title { get; set; }
        public int CreatorID { get; set; }
        public Nullable<int> MaintainerID { get; set; }
        public virtual Contact CreatorContact { get; set; }
        public virtual Contact MaintainerContact { get; set; }
        public virtual ICollection<Member> ProjectMembers { get; set; }
        public virtual ICollection<Contact> FavoritesContacts { get; set; }
    }
}
