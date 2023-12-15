using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

[Route("api/[controller]")]
[ApiController]
public class VisitorEntryController : ControllerBase
{
    private readonly MuseumContext _context;

    public VisitorEntryController(MuseumContext context)
    {
        _context = context;
    }

    // POST: api/VisitorEntry
    [HttpPost]
    public async Task<IActionResult> LogEntry([FromBody] VisitorEntry entry)
    {
        var area = await _context.MuseumAreas.FindAsync(entry.AreaID);
        if (area == null)
        {
            return NotFound("Area not found");
        }

        // Increment the visitor count in the area
        area.CurrentVisitorCount++;
        _context.Update(area);

        _context.VisitorEntries.Add(entry);
        await _context.SaveChangesAsync();

        return Ok(entry);
    }
}
