﻿using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************");
            Console.WriteLine("Welcome to Bank of Code");
            Console.WriteLine("***********************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create an account.");
                Console.WriteLine("2. Deposit Money.");
                Console.WriteLine("3. Withdraw Money.");
                Console.WriteLine("4. Print all accounts.");

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
                            var emailAddress = Console.ReadLine();

                            var accountTypes = Enum.GetNames(typeof(TypeOfAccount));
                            for (var i = 0; i < accountTypes.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}. {accountTypes[i]}");
                            }
                            Console.Write("Please select an account type: ");
                            var accountTypeOption = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Amount to deposit: ");
                            var initialDeposit = Convert.ToDecimal(Console.ReadLine());

                            var accountType = Enum.Parse<TypeOfAccount>(accountTypes[accountTypeOption - 1]);

                            var account = Bank.CreateAccount(emailAddress, accountType, initialDeposit);
                            Console.WriteLine($"Account Number: {account.AccountNumber}, Balance: {account.Balance:C}, Account Type: {account.AccountType}");
                        }
                        catch (FormatException fx)
                        {
                            Console.Write($"Error: {fx.Message}");
                        }
                        catch (IndexOutOfRangeException)
                        {
                            Console.WriteLine("Choose a valid account type and please try again.");
                        }
                        catch(ArgumentNullException ax)
                        {
                            Console.Write($"Error: {ax.Message}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Something went wrong! Please try again.");
                        }

                        break;
                    case "2":
                        PrintAllAccounts();
                        Console.Write("Account Number: ");
                        var accountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Deposit amount: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());

                        Bank.Deposit(accountNumber, amount);
                        Console.WriteLine("Deposit completed successfully!");
                        break;
                    case "3":
                        PrintAllAccounts();


                        try
                        {
                            Console.Write("Account Number: ");
                            accountNumber = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Withdraw amount: ");
                            amount = Convert.ToDecimal(Console.ReadLine());

                            Bank.Withdraw(accountNumber, amount);
                            Console.WriteLine("Withdraw completed successfully!");
                        }
                        catch(NSFException nx)
                        {
                            Console.Write($"Error: {nx.Message}");
                        }

                        break;
                    case "4":
                        PrintAllAccounts();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void PrintAllAccounts()
        {
            var accounts = Bank.GetAllAccounts();
            foreach (var acnt in accounts)
            {
                Console.WriteLine($"Account Number: {acnt.AccountNumber}, Balanace: {acnt.Balance:C}, Account Type: {acnt.AccountType}");
            }
        }
    }
}
