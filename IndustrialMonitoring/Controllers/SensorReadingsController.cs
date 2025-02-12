using Microsoft.AspNetCore.Mvc;
using IndustrialMonitoring.Core.Entities;
using IndustrialMonitoring.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace IndustrialMonitoring.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SensorReadingsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SensorReadingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SensorReading>>> GetLatestReadings()
        {
            var readings = await _context.SensorReadings
                .OrderByDescending(r => r.Timestamp)
                .Take(100)
                .ToListAsync();

            return Ok(readings);
        }

        [HttpPost]
        public async Task<ActionResult<SensorReading>> CreateReading(SensorReading reading)
        {
            reading.Timestamp = DateTime.UtcNow;
            _context.SensorReadings.Add(reading);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetLatestReadings), new { id = reading.Id }, reading);
        }
    }
}