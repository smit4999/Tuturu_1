using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_Tuturu_1.Models;
using Web_Tuturu_1.Services.Interfaces;

namespace Web_Tuturu_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IGetServices _getServices;

        [HttpPost]
        public User Create (User user)
        {
            return _getServices.Create(user);
        }

        [HttpPatch]
        public User Update (User user)
        {
            return _getServices.Update(user);
        }

        [HttpGet("{id}")]
        public User Get (int id) 
        {
            return _getServices.Get(id);
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return _getServices.GetAll();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            _getServices.Delete(id);
            return Ok();
        }
    }
}
