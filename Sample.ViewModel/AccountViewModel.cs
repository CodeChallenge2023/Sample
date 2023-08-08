using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sample.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName is requried!")]
        [Display(Name = "User Name")]               
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is requried!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}
