using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CropDeal_WebAPI.Data;
using CropDeal_WebAPI.Models;

namespace Crop_Deal1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CropdetailController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public CropdetailController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET: api/Cropdetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cropdetail>>> GetCropdetails()
        {
            if (context.Cropdetails == null)
            {
                return NotFound();
            }
            return await context.Cropdetails.ToListAsync();
        }

        // GET: api/Cropdetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cropdetail>> GetCropdetail(int id)
        {
            if (context.Cropdetails == null)
            {
                return NotFound();
            }
            var cropdetail = await context.Cropdetails.FindAsync(id);

            if (cropdetail == null)
            {
                return NotFound();
            }

            return cropdetail;
        }

        // PUT: api/Cropdetail/5
        // To protect from overposting attacks, 
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCropdetail(int id, Cropdetail cropdetail)
        {
            if (id != cropdetail.Crop_Details_id)
            {
                return BadRequest();
            }

            context.Entry(cropdetail).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CropdetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }




        // POST: api/Cropdetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Cropdetail>> PostCropdetail(Cropdetail cropdetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                context.Cropdetails.Add(cropdetail);
                await context.SaveChangesAsync();

                return CreatedAtAction("GetCropdetail", new { id = cropdetail.Crop_Details_id }, cropdetail);
            }
            catch (DbUpdateException ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error occurred while saving the crop detail. Please try again.");
            }
        }

        // POST: api/Cropdetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /* [HttpPost]
         public async Task<ActionResult<Cropdetail>> PostCropdetail(Cropdetail cropdetail)
         {
             if (context.Cropdetails == null)
             {
                 return Problem("Entity set 'ApplicationDbContext.Cropdetails' is null.");
             }
             context.Cropdetails.Add(cropdetail);
             await context.SaveChangesAsync();

             return CreatedAtAction("GetCropdetail", new { Cropid = cropdetail.Crop_Details_id }, cropdetail);
         }
        */

        // DELETE: api/Cropdetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCropdetail(int id)
        {
            if (context.Cropdetails == null)
            {
                return NotFound();
            }
            var cropdetail = await context.Cropdetails.FindAsync(id);
            if (cropdetail == null)
            {
                return NotFound();
            }

            context.Cropdetails.Remove(cropdetail);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool CropdetailExists(int id)
        {
            return (context.Cropdetails?.Any(a => a.Crop_Details_id == id)).GetValueOrDefault();
        }
    }
}