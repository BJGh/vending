using System.ComponentModel.DataAnnotations;

namespace vending.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Quantity")]
        public int Count { get; set; }

        [Display(Name = "Price")]
        public int Value { get; set; }

        public string Image { get; set; }

        public int Ordered { get; set; }

        public ProductModel() { }
        public ProductModel(Drink drink)
        {
            Id = drink.Id;
            Name = drink.Name;
            Count = drink.Count;
            Value = drink.Value;
            Image = drink.Image;
            Ordered = 0;
        }
    }
}
