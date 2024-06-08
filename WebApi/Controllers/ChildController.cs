using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SERVICES.Interfaces;
using SERVICES.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors()]
    public class ChildController : ControllerBase
    {
        readonly IChildService childService;
        public ChildController(IChildService _childService)
        {
            childService = _childService;
        }
        // GET: api/<ChildController>
        [HttpGet]

        public async Task<List<ChildModel>> Get()
        {
          return await childService.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChildModel> Get(int id)
        {
           return await childService.GetByIdAsync(id);
        }

        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChildModel> Post([FromBody] ChildModel value)
        {
           return await childService.AddAsync(value);
        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
