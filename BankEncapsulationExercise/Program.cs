using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            BankAccount acct1 = new BankAccount();
            acct1.name = "Anu Heru";
            do
            {
                Console.WriteLine();
                Console.WriteLine("What can we help you with?");
                Console.WriteLine("- Deposit \n" +
                    "- Withdraw \n" +
                    "- Check Balance \n" +
                    "- Exit");
                response = Console.ReadLine();
                
                switch (response.ToLower())
                {
                    case "deposit":
                        acct1.Deposit();
                        break;
                    case "withdraw":
                    case "withdrawl":
                        acct1.WIthdraw();
                        break;
                    case "balance":
                    case "check balance":
                        acct1.GetBalance();
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Not a valid input.");
                        break;
                }

            } while (response.ToLower() != "exit");
        }
        
    }
}
