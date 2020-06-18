using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public partial class UserLogin
    {
        public UserLogin()
        {
            //UserDetails = new HashSet<UserDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        //public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}