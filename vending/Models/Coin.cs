namespace vending.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public int Reserve { get; set; }
        public bool IsBlocked { get; set; }
        public int Inserted { get; set; }
        public string Image { get; set; }
    }
}
