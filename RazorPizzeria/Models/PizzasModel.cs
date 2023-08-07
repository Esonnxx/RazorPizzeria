namespace RazorPizzeria.Models
{
    public class PizzasModel
    {
        public string ImageTitle { get; set; }

        public string PizzaName { get; set; }
        public bool PanCrust { get; set; }

        public bool ThinCrust { get; set; }

        public int BasePrice { get; set; } 
        public bool TomatoSouce { get; set; }

        public bool Cheese { get; set; }

        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Onion { get; set; }
        public bool Pineapple { get; set; }

        public bool Ham { get; set; }
        public bool Shrimp { get; set; }
        public bool Beef { get; set; }

        public bool Chicken { get; set; }

        public int FinalPrice { get; set; }







    }
}
