
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
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
      /* // [ForeignKey("User")]
        public int User_id { get; set; }

        [JsonIgnore]
        public User User { get; set; }
        //------------------------------------------------------------------------------------
        [ForeignKey("Cropdetail")]
        public int Crop_Details_id { get;set; }

        [JsonIgnore]
        public Cropdetail Cropdetail { get; set; }
        */
        public int User_id { get; set; }
        [JsonIgnore]
        public User User { get; set; }

        public int Crop_Detaila_id { get; set; }
        [JsonIgnore]
        public Cropdetail Cropdetail { get; set; }  

        
    }
}
