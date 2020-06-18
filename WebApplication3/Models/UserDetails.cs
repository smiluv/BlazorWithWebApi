using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public partial class UserDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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