using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropdetailController : ControllerBase
    {
        private readonly ICropdetail cropdetail;

        public CropdetailController(ICropdetail cropdetail)
        {
            this.cropdetail = cropdetail;
        }

        [HttpGet]
        public async Task<ActionResult<List<Cropdetail>>> Get()
        {
            var cropdetails = await cropdetail.GetCropdetails();
            return Ok(cropdetails);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cropdetail>> Get(int id)
        {
            var cropdetailById = await cropdetail.GetCropdetail(id);
            if (cropdetailById == null)
            {
                return NotFound();
            }

            return Ok(cropdetailById);
        }

       
    }
}
