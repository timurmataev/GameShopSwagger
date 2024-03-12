using GameShopSwaggerUI2.DTO;
using GameShopSwaggerUI2.Objects;

namespace GameShopSwaggerUI2.Interfaces
{
    public interface IGameService
    {
        public Task<GameForDataBase> Search(int id);

        public Task Add(GameDTO game);


    }
}
