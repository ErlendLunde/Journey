using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class UserController: ControllerBase
    {
        private readonly Datacontext _context;

        public UserController(Datacontext context)
        {
            _context = context;
        }
        [HttpGet("GetUsers")]
        public IEnumerable<User> GetUsers()
        {
            IEnumerable<User> users = _context.User.ToList();
            return users;
        }

        [HttpPost("AddUsers")]
        public IActionResult AddUser(User user)
        {
            _context.User.Add(user);
            if (_context.SaveChanges() > 0)
            {
                return Ok();
            }
            return BadRequest();

        }
    }
}
