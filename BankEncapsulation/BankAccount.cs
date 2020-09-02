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
        public void Deposit() //double because it could be a decimal
                                           //amount because it makes sense to name as the amount of the deposit 
        {
            Console.WriteLine("How much would you like to deposit?");

            balance += Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your new balance is {GetBalance()}");
            Console.WriteLine("Would you like to make another deposit? Yes or No?");
            var depositAgain = Console.ReadLine().ToLower();


     

            
            while (depositAgain == "yes")
            {
                Console.WriteLine("How much more would you like to deposit?");
                balance += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Your new balance is {GetBalance()}");
                Console.WriteLine("Would you like to make another deposit? Yes or No?");
                depositAgain = Console.ReadLine().ToLower();
            }
                if (depositAgain == "no")
                {
                    Console.WriteLine($"Your current balance is {GetBalance()}. Have a nice day!");
                }
                    
                
           
                

                
          
            

              

           
        }


        //Define a method named GetBalance that will return the amount stored in the balance field
        public double GetBalance()        
        {
            return balance;             //Can work with balance here because it is inside the class it was assigned
        }

        
       

    }
}
