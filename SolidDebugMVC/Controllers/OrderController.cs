using Microsoft.AspNetCore.Mvc;
using SolidDebugMVC.Models;
using SolidDebugMVC.Services;

namespace SolidDebugMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderManager _manager = new OrderManager();

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(Order order)
        {
            return Content(
                "Name: " + order.CustomerName +
                " | Amount: " + order.Amount +
                " | Payment: " + order.PaymentType +
                " | Notification: " + order.NotificationType
            );
        }

    }
}
