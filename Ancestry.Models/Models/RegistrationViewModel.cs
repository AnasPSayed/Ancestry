using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Models
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage = "User Name required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email required")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Sex { get; set; }
        public string DOB { get; set; }
        public string Mobile { get; set; }
        public string Profession { get; set; }
        public string HouseName { get; set; }
    }
}
