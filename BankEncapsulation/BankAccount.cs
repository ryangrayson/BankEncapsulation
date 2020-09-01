using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
        }

        //Create a private field of type double named balance with a value of 0
        private double balance = 0; //"balance" is what you're trying to protect, or encapsulate

        //Define a method named Deposit that will accept a double and store that value in the balance field


        //Encapsulation
        public void Deposit(double amount) //double because it could be a decimal
                                           //amount because it makes sense to name as the amount of the deposit 
        {
            balance = amount;
        }


        //Define a method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()        
        {
            return balance;             //Can work with balance here because it is inside the class it was assigned
        }

        
       

    }
}
