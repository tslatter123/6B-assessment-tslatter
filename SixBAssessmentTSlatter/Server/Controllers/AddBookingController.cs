using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SixBAssessmentTSlatter.Server.Data;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddBookingController : ControllerBase
    {
        ApplicationDbContext _context;

        public AddBookingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddBooking(Booking booking)
        {
            try
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();

                return Ok();
            }
            catch
            {
                throw;
            }
        }
    }
}
