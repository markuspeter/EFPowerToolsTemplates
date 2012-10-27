using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Project
    {
        public Project()
        {
            this.Members = new List<Member>();
            this.Contacts = new List<Contact>();
        }

        public int ProjectID { get; set; }
        public string Title { get; set; }
        public int CreatorID { get; set; }
        public Nullable<int> MaintainerID { get; set; }
        public virtual Contact Contact { get; set; }
        public virtual Contact Contact1 { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
