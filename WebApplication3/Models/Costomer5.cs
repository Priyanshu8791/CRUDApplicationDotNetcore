using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace WebApplication3.Models
{
    public partial class Costomer5
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Required Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required Dob")]
        public string Dob { get; set; }
        [Required(ErrorMessage = "Required CountryId")]
        public int? CountryId { get; set; }
        [Required(ErrorMessage = "Required StateId")]
        public int? StateId { get; set; }
        [Required(ErrorMessage = "Required Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required ConformPass")]
        public string ConformPass { get; set; }
        [Required(ErrorMessage = "Required Country")]
        [ForeignKey("CountryId")]
        public virtual Country5 Country { get; set; }
        [Required(ErrorMessage = "Required State")]
        [ForeignKey("StateId")]
        public virtual State2 State { get; set; }
    }
}
