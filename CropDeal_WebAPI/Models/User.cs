using System.ComponentModel.DataAnnotations;

namespace CropDeal_WebAPI.Models
{
    public class User
    {
        //------------------------------------------------------------------------------------------------
        [Key]
        public int User_Id { get; set; }
        //--------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your Name")]
        [StringLength(50, MinimumLength = 3)]
        public string? User_Name { get; set; }
        //---------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your E-mail")]
        [EmailAddress(ErrorMessage = "Please Enter Valid E-mail Address")]
        public string? User_Email { get; set; }
        //-----------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter The Password")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Required]
        public byte[]? PasswordHash { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }
        //-----------------------------------------------------------------------------------------------------
        [Required(ErrorMessage ="Please Enter The Contact Number")]
        [RegularExpression(@"^[0-9]{10}$",ErrorMessage ="Please Enter Valid Contact Number")]
        [Display(Name ="Contact Number")]
        public string? User_Contact { get; set; }
        //-----------------------------------------------------------------------------------------------------

        [Required(ErrorMessage ="Please ENter Your Date of Birth")]
        [DataType(DataType.Date)] 
        public DateTime? DateOfBirth { get; set;}
        //-------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage ="Please Enter Your Addres")]
        public string? User_Address { get; set; }
        //---------------------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Select Your Role")]
        public string? User_Roles { get; set; } = string.Empty;
        //----------------------------------------------------------------------------------------------------------


        public bool Is_Suscribed { get; set; } = false;
        public bool Is_Active { get; set; } = false;

    }
}
