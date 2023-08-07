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
                PizzaName = "���A�`��", 
                BasePrice = 300, 
                TomatoSouce = true, 
                Cheese = true, 
                FinalPrice =360},
            new PizzasModel() {
                ImageTitle = "Pizza",
                PizzaName = "�L�¦i�`��",
                BasePrice = 300,
                TomatoSouce = true,
                Cheese = true,
                FinalPrice =360},
            new PizzasModel() {
                ImageTitle = "Pizza",
                PizzaName = "�������\",
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
