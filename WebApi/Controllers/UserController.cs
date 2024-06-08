using Microsoft.AspNetCore.Mvc;
using SERVICES.Interfaces;
using SERVICES.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        // GET: api/<UserController>
        [HttpGet]

        public async Task<List<UserModel>> Get()
        {
            return await _userService.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserModel> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserModel> Post([FromBody] UserModel value)
        {
            return await _userService.AddAsync(value);
        }

        // PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] UserModel value)
        //{
        //    _userService.UpdateAsync(value);
        //}

        // DELETE api/<UserController>/5
        //[HttpDelete("{id}")]
        //public void DeleteAsync(int id)
        //{
        //}
    }
}
