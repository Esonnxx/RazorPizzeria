using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel() {
                ImageTitle = "Pizza", 
                PizzaName = "海鮮總匯", 
                BasePrice = 300, 
                TomatoSouce = true, 
                Cheese = true, 
                FinalPrice =360},
            new PizzasModel() {
                ImageTitle = "Pizza",
                PizzaName = "夏威夷總匯",
                BasePrice = 300,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice =360},
            new PizzasModel() {
                ImageTitle = "Pizza",
                PizzaName = "海陸全餐",
                BasePrice = 400,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice =460},
        };
        
        public void OnGet()
        {
        }
    }
}
