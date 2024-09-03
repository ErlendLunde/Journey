using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class JourneyController : ControllerBase
    {
        private readonly Datacontext _context;

        public JourneyController(Datacontext context)
        {
            _context = context;
        }
        [HttpGet("GetJourneys")]
        public IEnumerable<Journey> GetJourneys() 
        {
            IEnumerable<Journey> journeys = _context.Journey.ToList<Journey>();
            return journeys;
        }

        [HttpPost("AddJourney")]
        public IActionResult AddJourney(Journey journey) 
        {
            _context.Journey.Add(journey);
            if(_context.SaveChanges() > 0)
            {
                return Ok();
            }
            return BadRequest();
            
        }
    }

}
