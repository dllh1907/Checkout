namespace Checkout.Models
{
    public class PaymentRequest
    {
        public string Token { get; set; }

        public string CardNumber { get; set; }

        public string Month { get; set; }

        public string Year { get; set; }

        public string Info { get; set; }

        public decimal Amount { get; set; }

        public string Currency { get; set; }

        public string Cvv { get; set; }

    }
}