using System.Collections.Generic;
using SolidDebugMVC.Models;

namespace SolidDebugMVC.Services
{
    public class OrderRepository
    {
        private static List<Order> orders = new List<Order>();

        public void Save(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return orders;
        }
    }
}
