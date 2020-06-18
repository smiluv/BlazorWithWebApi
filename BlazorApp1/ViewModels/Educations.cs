using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.ViewModels
{
    public class Educations
    {
        public decimal Id { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
