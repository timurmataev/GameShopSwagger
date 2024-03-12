using GameShopSwaggerUI.Data;
using GameShopSwaggerUI2.DTO;
using GameShopSwaggerUI2.Interfaces;
using GameShopSwaggerUI2.Objects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameShopSwaggerUI2.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationContext _context;

        public GameService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<GameForDataBase> Search(int id)
        {
            var game = await _context.Games.FirstOrDefaultAsync(x => x.Id == id);

            return game;
        }

        public async Task Add(GameDTO gameDto)
        {

            var game = new GameForDataBase()
            {
                NameGame = gameDto.NameGame,
                TypeGame = gameDto.TypeGame,
                PriceGame = gameDto.PriceGame,
                Id = gameDto.Id,
            };

            _context.Games.Add(game);
            await _context.SaveChangesAsync();

        }
    }
}
