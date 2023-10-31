namespace Solid.DIP.After
{
    public class Order
    {
        public string PayingAccount { get; set; }

        public string DestinationAccount { get; set; }

        public decimal Total { get; set; }
    }

    public interface IPaymentProcessor
    {
        void MakePayment(string from, string to, decimal amount);
    }

    public abstract class PaymentProcessor : IPaymentProcessor
    {
        public abstract void MakePayment(string from, string to, decimal amount);
    }

    public class PaypalPaymentProcessor : PaymentProcessor
    {
        public override void MakePayment(string from, string to, decimal amount)
        {
            Console.WriteLine($"Paypal paying {amount} from {from} to {to}");
        }
    }

    public class OrderCheckout
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public OrderCheckout(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void PerformCheckout()
        {
            Order order = new Order
            {
                PayingAccount = "the user",
                DestinationAccount = "the online shop",
                Total = 100
            };

            // now we can accomodate any payment processor without changes here
            _paymentProcessor.MakePayment(order.PayingAccount, order.DestinationAccount, order.Total);
        }
    }

}
