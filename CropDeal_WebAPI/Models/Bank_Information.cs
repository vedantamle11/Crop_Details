using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CropDeal_WebAPI.Models;


namespace CropDeal_WebAPI.Models
{
    public class Bank_Information
    {
        //---------------------------------------------------------------------------------------------
        [Key]
        [Required]
        public int BankDetail_id { get; set;}
        //---------------------------------------------------------------------------------------------
        
        [Required(ErrorMessage = "Please Enter Your Bank Name")]
        [Display(Name="BankName")]   
        public string? Bank_Name { get; set; }
        //----------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your Bank Account Number")]
        [RegularExpression(@"^([0-9]{9,18})$", ErrorMessage = "Please Enter Valid Bank Account Number")]
        [Display(Name ="AccountNumber")]
        public int? Bank_Account_No { get; set; }
        //-----------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter IFSC Number")]
        [RegularExpression(@"^(A-Z|a-z]{4}[0][a-zA-Z0-9]{6})$", ErrorMessage = "Please Enter Valid IFSC Code")]
        [Display(Name ="IFSC")]
        public string? IFSC { get; set; }
        //-------------------------------------------------------------------------------------------------
        [ForeignKey("User")]
        public int User_Id { get; set; }
        public User? User { get; set; } 

    }
}
