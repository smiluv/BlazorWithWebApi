using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class UserDetails
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long? LoginId { get; set; }
        public long? EducationId { get; set; }

        public virtual Education Education { get; set; }
        public virtual UserLogin Login { get; set; }
    }
}
