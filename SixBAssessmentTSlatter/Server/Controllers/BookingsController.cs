using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SixBAssessmentTSlatter.Server.Data;
using SixBAssessmentTSlatter.Shared.Models;

namespace SixBAssessmentTSlatter.Server.Controllers
{
    public class BookingsController
    {

        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpGet]
        public async Task<IEnumerable<Booking>> Bookings()
        {
            return await _context.Bookings.ToArrayAsync();
        }
    }
}
