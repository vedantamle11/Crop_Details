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

        [HttpPost]
        public async Task<ActionResult<Cropdetail>> Post(Cropdetail cropdetailToAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var createdCropdetail = await cropdetail.CreateCrop_acc(cropdetailToAdd);
            return CreatedAtAction(nameof(Get), new { id = createdCropdetail.Crop_Details_id }, createdCropdetail);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Cropdetail>> Put(int id, Cropdetail cropdetailToUpdate)
        {
            var updatedCropdetail = await cropdetail.UpdateCropdetail(id, cropdetailToUpdate);
            if (updatedCropdetail == null)
            {
                return NotFound();
            }

            return Ok(updatedCropdetail);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Cropdetail>> Delete(int id)
        {
            var deletedCropdetail = await cropdetail.DeleteCrop_acc(id);
            if (deletedCropdetail == null)
            {
                return NotFound();
            }

            return Ok(deletedCropdetail);
        }
    }
}
