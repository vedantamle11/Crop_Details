using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CropDeal_WebAPI.Models;
namespace CropDeal_WebAPI.Models
{
    public class Crop
    {
        //------------------------------------------------------------------------------------------------
        [Key]
        [Required]
        public int Crop_id { get; set; }

        //-------------------------------------------------------------------------------------------------
        [Required(ErrorMessage ="Please Enter The Crop Name")]
        [Display(Name ="CropName")]
        public string? Crop_name { get; set; }

        //--------------------------------------------------------------------------------------------------

        [Required]
        public string? Crop_Image { get; set; }
        //----------------------------------------------------------------------------


       // [ForeignKey("User")]
        public int User_id { get; set; }   
        public User? User { get; set; }
        //-----------------------------------------------
       // [ForeignKey("Cropdetail")]
        public int Crop_Details_id { get; set; }
        public Cropdetail? Cropdetail { get; set; }
    }
}
