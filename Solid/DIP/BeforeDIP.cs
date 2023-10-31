namespace Solid.DIP.Before
{
    public class Order
    {
        public string PayingAccount { get; set; }

        public string DestinationAccount { get; set; }

        public decimal Total { get; set; }
    }

    public class PaypalPaymentProcessor
    {
        public void MakePayment(string from, string to, decimal amount)
        {
            Console.WriteLine($"Paypal paying {amount} from {from} to {to}");
        }
    }

    public class OrderCheckout
    {
        public void PerformCheckout()
        {
            Order order = new Order
            {
                PayingAccount = "the user",
                DestinationAccount = "the online shop",
                Total = 100
            };

            PaypalPaymentProcessor paymentProcessor = new PaypalPaymentProcessor();
            paymentProcessor.MakePayment(order.PayingAccount, order.DestinationAccount, order.Total);   

            // what about when another payment processor gets added (e.g.: Stripe)?
        }
    }
}
