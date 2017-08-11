using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Backend.Models
{
    public class UserView : User
    {
        [Display(Name = "Picture")]
        public HttpPostedFileBase PictureFile { get; set; }

        [Display(Name = "Favorite League")]
        public int FavoriteLeagueId { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(20, ErrorMessage = "The length for field {0} must be between {1} and {2} characters")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "The field {0} is required")]
        [Compare("Password", ErrorMessage = "The Password and Confirm does not match")]
        [Display(Name = "Password Confirm")]
        public string PasswordConfirm { get; set; }
    }
}