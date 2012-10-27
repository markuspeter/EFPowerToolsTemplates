using System;
using System.Collections.Generic;

namespace EFT.Models
{
    public class Contact
    {
        public Contact()
        {
            this.Members = new List<Member>();
            this.Projects = new List<Project>();
            this.Projects1 = new List<Project>();
        }

        public int ContactID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<Project> Projects1 { get; set; }
    }
}
