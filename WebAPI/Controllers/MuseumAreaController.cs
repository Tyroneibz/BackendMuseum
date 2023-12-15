using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuseumAreaController : ControllerBase
    {
        private readonly MuseumContext _context;

        public MuseumAreaController(MuseumContext context)
        {
            _context = context;
        }

        // GET: api/MuseumArea
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuseumArea>>> GetMuseumAreas()
        {
            return await _context.MuseumAreas.ToListAsync();
        }
        
    }
}
