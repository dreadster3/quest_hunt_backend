using QuestHunt.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace QuestHunt.Api.Controllers
{
    [ApiController]
    [Route("api/quests")]
    public class QuestController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger _logger;

        public QuestController(AppDbContext context, ILogger<QuestController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuests()
        {
            return Ok(await _context.Quests.ToListAsync());
        }
    }
}
