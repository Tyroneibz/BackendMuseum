using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class VisitorExitController : ControllerBase
{
    private readonly MuseumContext _context;

    public VisitorExitController(MuseumContext context)
    {
        _context = context;
    }

    // POST: api/VisitorExit
    [HttpPost]
    public async Task<IActionResult> LogExit([FromBody] VisitorExit exit)
    {
        var area = await _context.MuseumAreas.FindAsync(exit.AreaID);
        if (area == null)
        {
            return NotFound("Area not found");
        }

        // Decrement the visitor count in the area
        area.CurrentVisitorCount = Math.Max(0, area.CurrentVisitorCount - 1);
        _context.Update(area);

        _context.VisitorExits.Add(exit);
        await _context.SaveChangesAsync();

        return Ok(exit);
    }
}
