using GameShopSwaggerUI.Data;
using GameShopSwaggerUI2.DTO;
using GameShopSwaggerUI2.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameShopSwaggerUI2.Controllers
{
    [ApiController]
    [Route("add-game")]
    sealed public class AddNewGameController : ControllerBase
    {
        private readonly ApplicationContext _context;
        private readonly IGameService _gameService;

        public AddNewGameController(ApplicationContext context, IGameService game)
        {
            _context = context;
            _gameService = game;
        }

        [HttpGet("search-game")]
        public async Task<IActionResult> Get(int Id)
        {
            try
            {
                var game = await _gameService.Search(Id);

                if (game == null)
                    return await Task.FromResult<IActionResult>(BadRequest());

                return await Task.FromResult<IActionResult>(Ok(game));

            }
            catch (Exception ex)
            {
                return await Task.FromResult<IActionResult>(BadRequest(ex.Message));
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(GameDTO game)
        {
            _context.Add(game);
            return Ok();

        }
    }
}
