using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixBAssessmentTSlatter.Server.Data;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> Bookings()
        {
            return await _context.Bookings.ToArrayAsync();
        }

        [HttpPost]
        public async Task<ActionResult> EditBooking(Booking booking)
        {
            try
            {
                _context.Update(booking);
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
