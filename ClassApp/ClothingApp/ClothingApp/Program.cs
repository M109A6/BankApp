using System;

namespace ClothingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Welcome to Clothes");
            Console.WriteLine("******************");

            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account.");
            Console.WriteLine("2. Review Clothing Product");

            Console.Write("Please select an option: ");
            var option = Console.ReadLine();

            switch (option)
            {

                case "0":
                    return;
                case "1":
                    try
                    {
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
                    catch (FormatException fx)
                    {
                        Console.Write($"Error: {fx.Message}");
                    }
                    break;
                case "2":

                    break;



            }
        }

    }
}
