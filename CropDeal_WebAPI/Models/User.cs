using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using CropDeal_WebAPI.Models;

namespace CropDeal_WebAPI.Models
{
    public class User
    {
        //------------------------------------------------------------------------------------------------
        [Key]
        public int Userid { get; set; }
        //--------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(50, MinimumLength = 3)]
        public string? UserName { get; set; }
        //---------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your E-mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid E-mail Address")]
        public string? UserEmail_id { get; set; }
        //-----------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
       /* [Required]
        public byte[]? PasswordHash { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }*/
        //-----------------------------------------------------------------------------------------------------
        [Required(ErrorMessage ="Please Enter The Contact Number")]
        [RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Please Enter Valid Contact Number")]
        [Display(Name ="Contact Number")]
        public string? UserContact { get; set; }
        //-----------------------------------------------------------------------------------------------------

      
        [Required(ErrorMessage ="Please Enter Your Addres")]
        public string? UserAddress { get; set; }
        //---------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Select Your Role")]
        public string? UserRoles { get; set; } = string.Empty;
        //----------------------------------------------------------------------------------------------------------


        public bool Is_Suscribed { get; set; } = false;
        public bool Is_Active { get; set; } = false;

    }
}
