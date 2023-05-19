using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.DTO;
using CropDeal_WebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CropDeal_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropController : ControllerBase
    {
        private readonly ICrop cropRepository;

        public CropController(ICrop cropRepository)
        {
            this.cropRepository = cropRepository;
        }

        [HttpPost]
        public async Task<ActionResult<Crop>> CreateCrop(Cropdto cropdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var crop = new Crop
            {
                User_id = cropdto.User_id,

                Crop_name = cropdto.Crop_name,
                Crop_Image = cropdto.Crop_Image
            };

            var createdCrop = await cropRepository.CreateCrop(crop);
            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crop>>> GetCrops()
        {
            var crops = await cropRepository.GetCrops();
            return Ok(crops);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Crop>> GetCrop(int id)
        {
            var crop = await cropRepository.GetCrop(id);
            if (crop == null)
            {
                return NotFound();
            }
            return Ok(crop);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Crop>> UpdateCrop(int id, Cropdto cropdto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingCrop = await cropRepository.GetCrop(id);
            if (existingCrop == null)
            {
                return NotFound();
            }

            existingCrop.Crop_name = cropdto.Crop_name;
            existingCrop.Crop_Image = cropdto.Crop_Image;

            var updatedCrop = await cropRepository.UpdateCrop(id, existingCrop);
            return Ok(updatedCrop);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Crop>> DeleteCrop(int id)
        {
            var crop = await cropRepository.GetCrop(id);
            if (crop == null)
            {
                return NotFound();
            }

            var deletedCrop = await cropRepository.DeleteCrop(id);
            return Ok(deletedCrop);
        }
    }
}
