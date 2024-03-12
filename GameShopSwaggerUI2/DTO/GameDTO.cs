using GameShopSwaggerUI2.AbstractClasses;

namespace GameShopSwaggerUI2.DTO
{
    public class GameDTO : Game<int>
    {
        public override string NameGame { get; set; } = string.Empty;

        public override string TypeGame { get; set; } = string.Empty;

        public override int PriceGame { get; set; }

        public int Id { get; set; }

    }
}
