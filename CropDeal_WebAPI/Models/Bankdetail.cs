using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using CropDeal_WebAPI.Models;

namespace CropDeal_WebAPI.Models
{
    public class Bankdetail
    {
        //---------------------------------------------------------------------------------------------
        [Key]
        [Required]
        public int BankDetail_id { get; set; }
        //---------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your Bank Name")]
        [Display(Name = "BankName")]
        public string? Bank_Name { get; set; }
        //----------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter Your Bank Account Number")]
        [RegularExpression(@"^([0-9]{9,18})$", ErrorMessage = "Please Enter Valid Bank Account Number")]
        [Display(Name = "AccountNumber")]
    
        // changed data type to string
        public string? Bank_Account_No { get; set; } 

        //-----------------------------------------------------------------------------------------------

        [Required(ErrorMessage = "Please Enter IFSC Number")]
        [RegularExpression(@"^([A-Za-z]{4}[0][A-Za-z0-9]{6})$", ErrorMessage = "Please Enter Valid IFSC Code")] // fixed regex pattern
        [Display(Name = "IFSC")]
        public string? IFSC { get; set; }

        
    }
}
