using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty] // ∏j©wPizza ∏ÚPizzaModel
        public PizzasModel Pizza { get; set; }

        public int PizzaPrice { get; set; }
        public int PizzaBasePrice { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
           
            PizzaBasePrice = Pizza.PanCrust ? 200 : 250;
            PizzaPrice += PizzaBasePrice;
            if (Pizza.TomatoSouce) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 30;
            if (Pizza.Peperoni) PizzaPrice += 30;
            if (Pizza.Mushroom) PizzaPrice += 30;
            if (Pizza.Onion) PizzaPrice += 30;
            if (Pizza.Pineapple) PizzaPrice += 20;
            if (Pizza.Ham) PizzaPrice += 30;
            if (Pizza.Shrimp) PizzaPrice += 80;
            if (Pizza.Beef) PizzaPrice += 60;
            if (Pizza.Chicken) PizzaPrice += 50;

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
