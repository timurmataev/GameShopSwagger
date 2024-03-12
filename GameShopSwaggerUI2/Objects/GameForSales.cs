using GameShopSwaggerUI2.AbstractClasses;

namespace GameShopSwaggerUI.Objects
{
    public class GameForSales : Game<int>
    {
        public override string NameGame { get; set; } = string.Empty;

        public override string TypeGame { get; set; } = string.Empty;

        public override int PriceGame { get; set; }

        public string ManufacturerGame { get; set; } = string.Empty;

        public int IdGame { get; set; }

        public DateTime DatePublicationGame { get; set; }

        public void PrintData()
        {
            Console.WriteLine($"Игра: {NameGame}\nЖанр: {TypeGame}\nПроизводитель: {ManufacturerGame}\n" +
                              $"Цена: {PriceGame}\nНомер: {IdGame}\nДата выхода: {DatePublicationGame}\n");
        }


    }
}

