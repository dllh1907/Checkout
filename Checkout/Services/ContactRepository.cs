using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Checkout.Models;

namespace Checkout.Services
{
    public class ContactRepository
    {
        public List<Merchant> GetAllMerchants()
        {
            //to add database connection
            var listOfMerchant = new List<Merchant>
            {
                new Merchant
                {
                    Name = "Sony",
                    Id = 1,
                    Token = "d031c19d-e59e-41dc-9326-983dac980192"
                },
                new Merchant
                {
                    Name = "Apple",
                    Id = 2
                }
            };
            return listOfMerchant;
        }

        public Merchant GetMerchantByToken(string token)
        {
            var merchant = GetAllMerchants().FirstOrDefault(m => m.Token == token);

            return merchant;
        }
    }
}