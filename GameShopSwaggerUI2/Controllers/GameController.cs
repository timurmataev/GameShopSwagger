using Microsoft.AspNetCore.Mvc;
using GameShopSwaggerUI.Objects;
using GameShopSwaggerUI.Items;

namespace GameShopSwaggerUI2.Controllers
{
    [ApiController]
    [Route("games")]
    sealed public class GameController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetGame(int quantityGames)
        {
            try
            {
                if (quantityGames <= 0)
                    throw new Exception("Negative values ​​are not supported");

                var games = new List<GameForSales>();
                var random = new Random();

                for (int i = 0; i < quantityGames; i++)
                {
                    int choiceNameGame = random.Next(RandomItems.namesOfGames.Length);
                    int choiceTypeGame = random.Next(RandomItems.typesOfGames.Length);
                    int choiceManufacturerGame = random.Next(RandomItems.gameManufacturers.Length);

                    games.Add(new GameForSales
                    {
                        NameGame = RandomItems.namesOfGames[choiceNameGame],
                        TypeGame = RandomItems.typesOfGames[choiceTypeGame],
                        ManufacturerGame = RandomItems.gameManufacturers[choiceManufacturerGame],
                        PriceGame = random.Next(1000, 9999),
                        IdGame = random.Next(100, 999),
                        DatePublicationGame = new DateTime(random.Next(2000, 2024))
                    });
                }

                return await Task.FromResult<IActionResult>(Ok(games));
            }
            catch (Exception ex)
            {
                return await Task.FromResult<IActionResult>(BadRequest(ex.Message));
            }
        }


    }
}
