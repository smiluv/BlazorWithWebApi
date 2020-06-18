using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class UserLogin
    {
        public UserLogin()
        {
            //UserDetails = new HashSet<UserDetails>();
        }

        public decimal Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}
