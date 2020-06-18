using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public partial class Education
    {
        public Education()
        {
            //UserDetails = new HashSet<UserDetails>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public string Description { get; set; }

        //public virtual ICollection<UserDetails> UserDetails { get; set; }
    }
}