using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the main method of your application, create a new instance of the BankAccount class
            var ryansAccount = new BankAccount(); //--How to create a new instance of class BankAccount

            //Allow the user of the application to Deposit money and retrieve their balance through the console
            Console.WriteLine("Hello! How much would you like to deposit?");
            

            var amountToDeposit = double.Parse(Console.ReadLine());

            //Call the deposit method
            ryansAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! You have deposited ${amountToDeposit}\n" +
                $"Your balance is now ${ryansAccount.GetBalance()}");
            Console.Beep();

            Console.WriteLine("Would you like to make another deposit?\n" +
                "Type Y or N");

            var yes = Console.ReadLine($"{Y}");












            

        }
    }
}
