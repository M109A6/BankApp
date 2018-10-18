using System;

namespace ClothingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Clothes");

            Console.Write("Email Address: ");
            var userEmailAddress = Console.ReadLine();

            Console.Write("Shipping / Billing Address: ");
            var userAccountAddress = Console.ReadLine();

            var paymentInfo = Enum.GetNames(typeof(TypeOfPayment));
            for (var i = 0; i < paymentInfo.Length; i++)

                Console.Write("Payment Method: ");
            var userPaymentInfo = Console.ReadLine();
            var account = Shop.CreateAccount(userEmailAddress, userAccountAddress, userPaymentInfo);
        }
    }
}
