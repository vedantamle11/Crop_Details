using System.ComponentModel.DataAnnotations;

namespace CropDeal_WebAPI.DTO
{
    public class Cropdetailsdto
    {
        public string? Crop_Name { get; set; }
        

        public string? Crop_Details_Description { get; set; }
        

        public string? Crop_Type { get; set; }
        

        public int? Quantity { get; set; }
        

      //  public int? Price { get; set; }
       

        public string? Location { get; set; }
        

    }
}
