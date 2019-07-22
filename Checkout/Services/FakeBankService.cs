using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Checkout.Models;

namespace Checkout.Services
{
    public class FakeBankService: IFakeBankService
    {
        public PaymentResponse RequestBankPayment(PaymentRequest request)
        {
            return new PaymentResponse
            {
                Success = true,
                TransactionId = 12548
            };
        }
    }
}