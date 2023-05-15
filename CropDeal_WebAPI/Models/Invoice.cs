
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CropDeal_WebAPI.Models;

namespace CropDeal_WebAPI.Models
{
    public class Invoice
    {
        //---------------------------------------------------------------------------------
        [Key]
        public int Invoice_id { get; set; }
        //-----------------------------------------------------------------------------------

        [Required]
        public int Quantity { get; set; }
        //------------------------------------------------------------------------------------

        [Required]
        public string Payment_Mode { get; set; } = string.Empty;
        //-------------------------------------------------------------------------------------
        [Required]
        public double? Price { get; set; }
        //-----------------------------------------
        [Required]
        public string Status { get; set;} = string.Empty;
        //--------------------------------------------------------------------------------------
        [Required]
        public DateTime Date_created { get; set; }
        //--------------------------------------------------------------------------------------
       // [ForeignKey("User")]
        public int User_id { get; set; }
        public User? User { get; set; }
        //------------------------------------------------------------------------------------
       // [ForeignKey("Cropdetail")]
        public int Crop_Details_id { get;set; }
        public Cropdetail? Cropdetail { get; set; }
        
    }
}
