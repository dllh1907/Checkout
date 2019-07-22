using Checkout.Models;

namespace Checkout.Services
{
    public interface IFakeBankService
    {
        PaymentResponse RequestBankPayment(PaymentRequest request);
    }
}