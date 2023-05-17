using CropDeal_WebAPI.DTO;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

[Route("api/[controller]")]
[ApiController]
public class BankdetailController : ControllerBase
{
    private readonly IBankdetail repo;

    public BankdetailController(IBankdetail repo)
    {
        this.repo = repo;
    }

    [HttpPost]
    public async Task<ActionResult<Bankdetail>> PostBankdetail([FromBody] Bankdetaildto bankdetail)
    {
        var details = await repo.CreateBank_acc(bankdetail);
        if (details == null)
        {
            return BadRequest(); // Return BadRequest if the operation fails
        }
        return Ok(details); // Return the created Bankdetail in the response body
    }

    [HttpGet("GetUserwithBankdetails")]
    public async Task<ActionResult<List<Bankdetaildto>>> GetUserwithBankdetails()
    {
        var details = await repo.GetUserwithBankdetails();
        if (details == null)
        {
            return NotFound();
        }
        return Ok(details); // Return the list of Bankdetaildto in the response body
    }

    [HttpGet]
    public async Task<ActionResult<List<Bankdetaildto>>> GetBankdetails()
    {
        var details = await repo.GetBankdetails();
        var list = new List<Bankdetaildto>();
        foreach (var item in details)
        {
            list.Add(new Bankdetaildto()
            {
                Bank_Name = item.Bank_Name,
                Bank_Account_No = item.Bank_Account_No,
                IFSC = item.IFSC
            });
        }
        return Ok(list); // Return the list of Bankdetaildto instead of details in the response body
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Bankdetail>> GetBankdetail(int id)
    {
        var detail = await repo.GetBankdetail(id);
        if (detail == null)
        {
            return NotFound();
        }
        return Ok(detail); // Return the Bankdetail in the response body
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<Bankdetail>> UpdateBankdetail(int id, Bankdetail user)
    {
        var detail = await repo.UpdateBankdetail(id, user);
        if (detail == null)
        {
            return NotFound();
        }
        return Ok(detail); // Return the updated Bankdetail in the response body
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteBankdetail_acc(int id)
    {
        var details = await repo.DeleteBank_acc(id);
        if (details == null)
        {
            return NotFound();
        }
        return Ok(); // Return OK status in the response body
    }
}
