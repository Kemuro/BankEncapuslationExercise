using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationExercise
{
    class BankAccount
    {
        private double balance = 0;
        private string password = "12345";
        public string name;
        public bool Verification()
        {
            Console.Write("Enter your password: ");
            string response = Console.ReadLine();

            if (response == password)
            {
                Console.WriteLine($"Welcome {name}.");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect password.");
                return false;
            }
        }
        public void Deposit()
        {
            var verify = Verification();
            double value;
            double confirm;
            if(verify)
            {
                do { 
                    Console.WriteLine("How much would you like to deposit?");
                    value = Convert.ToDouble(Console.ReadLine());

                
                    Console.WriteLine($"You have selected to deposit ${value} into your account.");
                    Console.WriteLine("Please re-enter the amount to confirm your deposit.");

                    confirm = Convert.ToDouble(Console.ReadLine());
                    if (value == confirm)
                    {
                        balance += value;
                        Console.WriteLine($"${value} has successfully been added to your account.");
                    }
                } while (value != confirm);
            }
            
        }
        public void WIthdraw()
        {
            var verify = Verification();
            double value;
            double confirm;
            if (verify)
            {
                do
                {
                    Console.WriteLine("How much would you like to withraw?");
                    value = Convert.ToDouble(Console.ReadLine());
                    confirm = 0;

                    if (balance >= value)
                    {
                        Console.WriteLine($"You have selected to withdraw ${value} from your account.");
                        Console.WriteLine("Please re-enter the amount to confirm your withdrawl.");

                        confirm = Convert.ToDouble(Console.ReadLine());
                        if (value == confirm)
                        {
                            balance -= value;
                        }
                    }
                    else
                        Console.WriteLine("Error: ammount requested exceeds your current balance.");
                } while (value != confirm);

            }
        }
        public double GetBalance()
        {
            Verification();
            Console.WriteLine($"Your balance: ${balance}");
            return balance;
        }

    }
}
