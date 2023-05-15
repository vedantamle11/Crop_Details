using System.ComponentModel.DataAnnotations;

namespace CropDeal_WebAPI.DTO
{
    public class Userdto
    {
        
        public string? UserName { get; set; }
        

       
        public string? UserEmail_id { get; set; }
       
        
        public string? Password { get; set; }
       
        
       
        public string? UserContact { get; set; }
        

        
       
       
       
        public string? UserAddress { get; set; }
      
        public string? UserRoles { get; set; } = string.Empty;
        
        public bool Is_Suscribed { get; set; } = false;
    }
}
