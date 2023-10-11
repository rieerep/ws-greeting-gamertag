using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WorkshopGreetingEmailGamerTag.Data;
using WorkshopGreetingEmailGamerTag.Models;

namespace WorkshopGreetingEmailGamerTag.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GreetingController(ApplicationDbContext context)
        {
            _context = context;
        }

        //GET api/<GreetingController>
        [HttpGet]
        //[Authorize]
        public GreetingViewModel Get()
        {
            //skriv logik som hämtar userID.
            //var result = _context;

            return new GreetingViewModel() {Greeting = "Hello" };
        }

        
    }
}
