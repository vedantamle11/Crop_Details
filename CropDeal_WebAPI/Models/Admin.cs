﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


using CropDeal_WebAPI.Models;

namespace CropDeal_WebAPI.Models
{
    public class Admin
    {
        //------------------------------------------------------------
        [Key]
        public int Admin_id { get; set; }
        //-----------------------------------------------------------
        [Required]
        public string? Admin_name { get; set;}
        //-------------------------------------------------------------
        [Required]
        public string? Admin_Contact { get; set;}
        //--------------------------------------------------------------
        [Required] 
        public string? Admin_email { get; set;}
        //--------------------------------------------------------------
        [Required]
        public string? Admin_password { get; set;}
        //------------------------------------------------------------------
      
    }
}
