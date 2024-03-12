namespace GameShopSwaggerUI2.AbstractClasses
{
    public abstract class Game<TPrice>
    {
        public abstract string NameGame { get; set; }

        public abstract string TypeGame { get; set; }

        public abstract TPrice PriceGame { get; set; }


    }
}
