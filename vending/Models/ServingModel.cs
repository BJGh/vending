namespace vending.Models
{
    public class ServingModel
    {
        public List<ProductModel> Products { get; set; }
        public List<CoinModel> Coins { get; set; }
        public int Deposit { get; set; }
        public int Change { get; set; }
        public string Token { get; set; }
        public int Inserted { get; set; }
    }
}
