namespace Checkout.Models
{
    public class PaymentHistory
    {
        public int TransactionId { get; set; }
        public string TransactionInfo { get; set; }
        public string Amount { get; set; }
    }
}