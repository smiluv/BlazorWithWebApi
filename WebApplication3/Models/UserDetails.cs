using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class UserDetails
    {
        public decimal Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public decimal? LoginId { get; set; }
        public decimal? EducationId { get; set; }

        public virtual Education Education { get; set; }
        public virtual UserLogin Login { get; set; }
    }
}
