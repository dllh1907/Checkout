using System;
using System.Collections.Generic;
using Checkout.Models;
using Checkout.Utilities;

namespace Checkout.Services
{
    public class PaymentGatewayService : IPaymentGateway
    {
        private readonly ILogger _ILogger;
        private readonly IFakeBankService _fakeBankService;

        public PaymentGatewayService(ILogger logger, IFakeBankService fakeBankService)
        {
            _ILogger = logger;
            _fakeBankService = fakeBankService;
        }
        //public PaymentResponse RequestPayment(PaymentRequest request)
        //{
        //    //this is where you will communicate with bank 
        //    throw NotImplementedException;
        //}
        public PaymentResponse RequestPayment(PaymentRequest request)
        {
            //request to the fake bank
            //not implemented but this is the mock where it will have return a json and converted to an object response with JsonConverter.

            //json convertor of the bank response to paymentresponse object
            var response = new PaymentResponse
            {
                Success = true,
                TransactionId = 12548
            };

            return response;
        }


        public List<PaymentHistory> PaymentHistory(string token, DateTime startDate, DateTime endDate)
        {
            //request to the fake bank
            //not implemented but this is the mock where it will have return a json and converted to an object response with JsonConverter.


            //here would have use for each for all transactions and send back paymenthistory object
            var response = new List<PaymentHistory>
            {
                new PaymentHistory
                {
                    TransactionId = 12540,
                    Amount = "5820",
                    TransactionInfo = "Car Audi Parts 123542214"
                },
                new PaymentHistory
                {
                    TransactionId = 12541,
                    Amount = "7100",
                    TransactionInfo = "Car BMW Parts 123542285"
                }
            };
            
            return response;
        }
    }
}