using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Project
    {
        public Project()
        {
            this.ProjectIDMembers = new List<Member>();
            this.FavoritesContacts = new List<Contact>();
        }

        public int ProjectID { get; set; }
        public string Title { get; set; }
        public int CreatorID { get; set; }
        public Nullable<int> MaintainerID { get; set; }
        public virtual Contact CreatorIDContact { get; set; }
        public virtual Contact MaintainerIDContact { get; set; }
        public virtual ICollection<Member> ProjectIDMembers { get; set; }
        public virtual ICollection<Contact> FavoritesContacts { get; set; }
    }
}
