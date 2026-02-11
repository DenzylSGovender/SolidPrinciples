using SolidDebugMVC.Models;

namespace SolidDebugMVC.Services
{
    public class OrderManager
    {
        private OrderRepository _repository = new OrderRepository();

        public string ProcessOrder(Order order)
        {
            string result = "";

            if (order.PaymentType == "CreditCard")
                result += "Processed credit card payment. ";
            else if (order.PaymentType == "PayPal")
                result += "Processed PayPal payment. ";

            _repository.Save(order);

            result += "Order saved successfully. ";

            if (order.NotificationType == "Email")
                result += "Email notification sent.";
            else if (order.NotificationType == "SMS")
                result += "SMS notification sent.";

            return result;
        }
    }
}
