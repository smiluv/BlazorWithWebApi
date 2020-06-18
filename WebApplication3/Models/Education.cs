using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Education
    {
        public Education()
        {
            //UserDetails = new HashSet<UserDetails>();
        }

        public decimal Id { get; set; }
        public string Description { get; set; }

        //public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
