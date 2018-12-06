using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ancestry.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="User Name required")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
