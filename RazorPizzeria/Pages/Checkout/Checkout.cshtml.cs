using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Data;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Checkout
{
    [BindProperties (SupportsGet = true)] // �b HTTP GET �n�D�W�i��t���O���n���[�W [BindProperty] Attribute �P .cshtml ���� <input asp-for="xxx"> �I���AOnPost() �� Razor Page �]�|�۰ʱN�e�ݶǤJ�����ȼg�J�A
    //�i�٥h�ۤv Request.Form["xxx"] ���Ȫ��·�
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
                PizzaName = "�ȻsPizza";
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
