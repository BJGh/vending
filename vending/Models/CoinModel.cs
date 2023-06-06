using System.ComponentModel.DataAnnotations;

namespace vending.Models
{
    public class CoinModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Value { get; set; }

        [Display(Name = "stock")]
        public int Reserve { get; set; }

        public int Inserted { get; set; }

        public string Image { get; set; }

        [Display(Name = "block")]
        public bool IsBlocked { get; set; }

        public CoinModel() { }
        public CoinModel(Coin coin)
        {
            Id = coin.Id;
            Name = coin.Name;
            Value = coin.Value;
            Reserve = coin.Reserve;
            Inserted = coin.Inserted;
            Image = coin.Image;
            IsBlocked = coin.IsBlocked;
        }
    }
}
