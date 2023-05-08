using System.ComponentModel.DataAnnotations;

namespace CropDeal_WebAPI.Models
{
    public class CropDisplay
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
    }
}
