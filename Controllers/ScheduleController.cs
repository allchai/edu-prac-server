using Microsoft.AspNetCore.Mvc;
using server.Data;
using server.Services;

namespace server.Controllers
{
    [ApiController]
    [Route("api/schedule")]
    public class ScheduleController : ControllerBase
    {
        private readonly IScheduleService _service;

        public ScheduleController(IScheduleService service, AppDbContext _db)
        {
            _service = service;
        }

        // GET: api/schedule/group/{groupName}?start=2026-01-12&end=2026-01-17
        [HttpGet("group/{groupName}")]
        public async Task<IActionResult> GetSchedule(string groupName, DateTime start, DateTime end)
        {
            var result = await _service.GetScheduleForGroup(groupName, start.Date, end.Date);
            return Ok(result);
        }
    }
}
