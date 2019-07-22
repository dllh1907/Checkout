using System;
using System.Web.Http;
using Checkout.Models;
using Checkout.Services;
using Checkout.Utilities;

namespace Checkout.Controllers
{
    public class MerchantController : ApiController
    {
        private readonly ILogger _logger;
        private readonly IPaymentGateway _paymentGateway;

        public MerchantController(ILogger logger, IPaymentGateway paymentGateway)
        {
            _logger = logger;
            _paymentGateway = paymentGateway;
        }

        [HttpGet]
        [Route("api/merchant/login")]
        public IHttpActionResult AuthenticateMerchant([FromUri]string username, [FromUri] string password)
        {
            //Todo log attempt here with IP of user
            _logger.Log($"Authentication Started for user {username} with IP: {CommonHelper.GetUserIP()} Time: {DateTime.Now}");

            //get confirm if user information correct here using authentication service in database TODO would have make db if more time
            if (username == "SONY" && password == "S0NY")
            {
                _logger.Log($"Authentication Successful for user {username} with IP: {CommonHelper.GetUserIP()} Time: {DateTime.Now}");

                //todo token generator and put expiry date to token
                return Ok("d031c19d-e59e-41dc-9326-983dac980192");
            }


            //todo log error
            _logger.Log(
                $"Authentication ERROR for user {username} with IP: {CommonHelper.GetUserIP()} Time: {DateTime.Now}");
            return BadRequest("User not found");

        }

        [HttpGet]
        [Route("api/merchant/requestpayment")]
        public IHttpActionResult RequestPayment([FromUri] PaymentRequest paymentRequest)
        {
            //null check here for value
            if (string.IsNullOrEmpty(paymentRequest.Token) && string.IsNullOrEmpty(paymentRequest.CardNumber) &&
                string.IsNullOrEmpty(paymentRequest.Currency) && string.IsNullOrEmpty(paymentRequest.Cvv) &&
                string.IsNullOrEmpty(paymentRequest.Year) && string.IsNullOrEmpty(paymentRequest.Month))
            {
                return BadRequest("Mandatory value missing");
            }

            return Ok(_paymentGateway.RequestPayment(paymentRequest));
        }

        [HttpGet]
        [Route("api/merchant/requestpaymenthistory")]
        public IHttpActionResult RequestPaymentHistory([FromUri] string token, string dateStart, string dateEnd)
        {
            return Ok(_paymentGateway.PaymentHistory(token, Convert.ToDateTime(dateStart), Convert.ToDateTime(dateEnd)));

        }
    }
}
