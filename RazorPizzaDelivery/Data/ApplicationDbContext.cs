using Microsoft.EntityFrameworkCore;
using RazorPizzaDelivery.Models;
namespace RazorPizzaDelivery.Data
{
	public class ApplicationDbContext : DbContext
	{
        public  DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
    }
}
