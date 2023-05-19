using System.ComponentModel.DataAnnotations;

namespace CropDeal_WebAPI.DTO
{
    public class Cropdto
    {   
        public int User_id { get; set; }  
        public string? Crop_name { get; set; }

        public string? Crop_Image { get; set; }

    }
}
