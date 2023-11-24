using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;
using RazorPizzaDelivery.Data;
using RazorPizzaDelivery.Models;

namespace RazorPizzaDelivery.Pages
{
    public class OrdersModel : PageModel
    { 
        
        public List<PizzaOrder> PizzaOrders = new List<PizzaOrder>();
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
           PizzaOrders = _context.PizzaOrders.ToList();

        }
    }
}
