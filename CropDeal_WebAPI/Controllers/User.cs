using CropDeal_WebAPI.DTO;
using CropDeal_WebAPI.Interface;
using CropDeal_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using CropDeal_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using CropDeal_WebAPI.Repository;

namespace CropDeal_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : Controller
    {
        private readonly IUser repo;
        public UserController(IUser repo)
        {
            this.repo = repo;
        }

        //-------------------------Repository Dto used
        [HttpPost]
        public async Task<ActionResult<User>> PostUser(Userdto userd)
        {
            if (userd == null)
            {
                return BadRequest();
            }
            var user = new User()
            {
                UserName = userd.UserName,
                Password = userd.Password,
                UserEmail_id = userd.UserEmail_id,
                UserContact = userd.UserContact,
                UserAddress = userd.UserAddress,
                UserRoles = userd.UserRoles,
                Is_Suscribed = userd.Is_Suscribed,
            };
            user = await repo.CreateUser(user);
            return Ok(user);
        }
        //-----------------------------------------
        [HttpGet]
        public async Task<ActionResult<User>> GetUsers()
        {
            var user = await repo.GetUsers();
            if (user == null)
            {
                return BadRequest();
            }
            var userlist = new List<Userdto>();
            foreach (var i in user)
            {
                userlist.Add(new Userdto()
                {
                    UserName = i.UserName,
                    Password = i.Password,
                    UserEmail_id = i.UserEmail_id,
                    UserContact = i.UserContact,
                    UserAddress = i.UserAddress,
                    UserRoles = i.UserRoles,
                    Is_Suscribed = i.Is_Suscribed,
                });
            }
            return Ok(userlist);
        }
        //--------------------------------
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await repo.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        //---------------------
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User user)
        {
            if (user == null)
            {
                return NotFound();
            }
            var database_user = repo.UpdateUser(id, user);
            if (database_user == null)
            {
                NotFound();
            }
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id)
        {
            var user = await repo.DeleteUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}