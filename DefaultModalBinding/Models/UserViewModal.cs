using DefaultModalBinding.Attribute;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DefaultModalBinding.Models
{
    public class UserViewModal
    {
        [Required(ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Username")]
        [RegularExpression(".+@.+\\..+",ErrorMessage ="Please Enter Correct Email")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Compare("Password",ErrorMessage ="Confirm Password donn't match")]
        public string ConfirmPassword { get; set; }
        
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Enter Contact Number")]
        [RegularExpression(@"^[6789]\d{9}$",ErrorMessage ="Please Enter Correct Contact")]
        public string Contact { get; set; }
        [ValidateCheckBox(ErrorMessage = "Please Accept Terms")]
        public bool Term { get; set; }
    }
}
