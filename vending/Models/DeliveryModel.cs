namespace vending.Models
{
    public class DeliveryModel
    {
        public List<DeliveryEntityModel> Products { get; set; } = new List<DeliveryEntityModel>();

        public List<DeliveryEntityModel> Coins { get; set; } = new List<DeliveryEntityModel>();
    }
}
