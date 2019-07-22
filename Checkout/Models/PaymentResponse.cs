namespace Checkout.Models
{
    public class PaymentResponse
    {
        public bool Success { get; set; }
        public int TransactionId { get; set; }
        public string ErrorCode { get; set; }
    }
}