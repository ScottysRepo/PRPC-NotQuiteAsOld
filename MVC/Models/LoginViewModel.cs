using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace PRPC.Models
{
    public class LoginViewModel
    {
        //public string userName {get; set;}

        //public bool userName => !string.IsNullOrEmpty(RequestuserName);

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Username")]
        public string userName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Password")]
        public string passWord { get; set; }

        [Display(Name = "Email address")]
        [StringLength(60, MinimumLength = 7)]
        public string emailAddress { get; set; }
/*Don't really need for login, but may need for registration
        [Range(1, 100)]
        //[DataType(DataType.Currency)]
        [Column(TypeName = "char(10, 0)")]
        public char phoneNumber { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        [StringLength(30)]
        public string firstName { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string lastName { get; set; }
         */
    } 
}