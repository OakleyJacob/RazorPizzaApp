using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDelivery.Data;
using RazorPizzaDelivery.Models;

namespace RazorPizzaDelivery.Pages.Checkout
{
    [BindProperties(SupportsGet =true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice {  get; set; }
        public string ImageTitle {  get; set; }
        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context=context;
        }
        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Your";
            }
            else
            {
                PizzaName = PizzaName + "'s";
            }
			if (string.IsNullOrWhiteSpace(ImageTitle))
			{
                ImageTitle = "Create";
			}
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = ImageTitle;
            pizzaOrder.OrderPrice = PizzaPrice;
            _context.PizzaOrders.Add(pizzaOrder);
            _context.SaveChanges();
		}
    }
}
