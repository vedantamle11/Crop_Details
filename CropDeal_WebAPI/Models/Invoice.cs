
using System.ComponentModel.DataAnnotations;

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
        public string Status { get; set;} = string.Empty;
        //--------------------------------------------------------------------------------------
        [Required]
        public DateTime Date_created { get; set; }
        //--------------------------------------------------------------------------------------


    }
}
