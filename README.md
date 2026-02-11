# SOLID Principles Debugging Activity (C#)
## Applying SRP and OCP in an Enterprise Context
---

## Purpose

Students will need to analyse the poorly designed code, refactor it using the first two SOLID principles, and extend functionality without modifying existing logic — mirroring real enterprise development practices.

## Activity Structure

Students will work in pairs or small groups.

### Phases:
1. Analyse the provided code
2. Identify design issues
3. Refactor using SRP
4. Extend using OCP
5. Present design decisions

---

# Starter Code 

Run and analyse the following program:

```csharp
using System;

namespace SolidDebugExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderManager manager = new OrderManager();
            manager.ProcessOrder("John", 250, "Email", "CreditCard");
        }
    }

    public class OrderManager
    {
        public void ProcessOrder(string customerName, double amount, string notificationType, string paymentType)
        {
            // Handle payment
            if (paymentType == "CreditCard")
            {
                Console.WriteLine("Processing credit card payment...");
            }
            else if (paymentType == "PayPal")
            {
                Console.WriteLine("Processing PayPal payment...");
            }

            // Save order
            Console.WriteLine("Saving order for " + customerName);

            // Generate report
            Console.WriteLine("Generating order report...");

            // Send notification
            if (notificationType == "Email")
            {
                Console.WriteLine("Sending email notification...");
            }
            else if (notificationType == "SMS")
            {
                Console.WriteLine("Sending SMS notification...");
            }
        }
    }
}
