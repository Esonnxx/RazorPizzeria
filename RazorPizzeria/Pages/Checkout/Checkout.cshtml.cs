using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties (SupportsGet = true)] // 在 HTTP GET 要求上進行系結是必要的加上 [BindProperty] Attribute 與 .cshtml 中的 <input asp-for="xxx"> 呼應，OnPost() 時 Razor Page 也會自動將前端傳入的欄位值寫入，
    //可省去自己 Request.Form["xxx"] 取值的麻煩
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public string PizzaName { get; set; }
        public int PizzaPrice { get; set; }
        public string ImageTitle { get; set; }
        public void OnGet()
        {
            if (string.IsNullOrEmpty(PizzaName))
                PizzaName = "客製Pizza";
            if (string.IsNullOrEmpty(ImageTitle))
                ImageTitle = "CreatePizza";

            PizzaOrderModel pizzaOrder = new PizzaOrderModel();
            
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();



        }
        
    }
}
