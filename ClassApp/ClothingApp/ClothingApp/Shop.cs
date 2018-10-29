using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClothingApp
{
    static class Shop
    {
        /// <summary>
        /// Create an account in the back
        /// </summary>
        /// <param name="userAccountEmail">Email Address associated to the account.</param>
        /// <param name="userAccountAddress">Type of account.</param>
        /// <param name="userAccountPaymentt">Checkout amount.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException" />
        public static UserAccount CreateAccount(string userAccountEmail, string userAccountAddress, string userAccountPayment)
        {
            if (string.IsNullOrEmpty(userAccountEmail))
            {
            throw new ArgumentNullException(nameof(userAccountEmail), "Email address is required!");
            }
                var account = new UserAccount
                {
                    UserAccountEmail = userAccountEmail,
                    UserAccountAddress = userAccountAddress,
                    UserAccountPayment = userAccountPayment
                };
                    
            return account;
        }
    }

}
