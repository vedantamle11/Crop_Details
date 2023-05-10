using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using CropDeal_WebAPI.Models;
namespace CropDeal_WebAPI.Models
{
    public class CropDetails
    {
        //------------------------------------------------------------------------------------
        [Key]
        [Required]
        public int Crop_Details_Id { get; set; }
        //--------------------------------------------------------------------------------------
        [Required]
        public string? Crop_Name { get; set; }
        //--------------------------------------------------------------------------------------
        [Required]
        public string? Crop_Details_Description { get; set; }
        //----------------------------------------------------------------------------------------
        [Required]
        public string? Crop_Type { get; set; }
        //-----------------------------------------------------------------------------------------
        [Required]
        public int? Quantity { get; set; }
        //----------------------------------------------------------------------------------------
        [Required]
        public int? Price { get; set; }
        //------------------------------------------------------------------------------------------
        [Required]
        public string? Location { get; set; }  
        //-------------------------------------------------------------------------------------------
    }
}
