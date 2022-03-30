using ASP_NET_Video_Games_API.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ASP_NET_Video_Games_API.Controllers;

namespace ASP_NET_Video_Games_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetGames()
        {
            var videoGames = _context.VideoGames;

            foreach (var videogame in videoGames)


            return Ok(videoGames);
        }


        [HttpGet("{Id}")]

        public IActionResult GetGamesById(int Id)
        {
            int? maxYear = _context.VideoGames.Select(vg => vg.Year).Max();
            int? minYear = _context.VideoGames.Select(vg => vg.Year).Min();

            var videoGames = _context.VideoGames.Where(vg => vg.Id == Id);
            return Ok();
        }

    }
}