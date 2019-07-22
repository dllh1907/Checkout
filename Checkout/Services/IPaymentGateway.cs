using System;
using System.Collections.Generic;
using Checkout.Models;

namespace Checkout.Services
{
    public interface IPaymentGateway
    {
        PaymentResponse RequestPayment(PaymentRequest request);

        List<PaymentHistory> PaymentHistory(string userId, DateTime startDate, DateTime endDate);
    }
}