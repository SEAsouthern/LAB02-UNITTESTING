using System;

namespace LAB02_UNITTESTING
{
    class Program

    {   //Initial balance for ATM program
        static int Balance = 3000;
        static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("Welcome to your Bank");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 1 to Check Balance.");
            Console.WriteLine("Press 3 to Deposit money.");
            string UserChoice = Console.ReadLine();
            int UserChoiceInt = Convert.ToInt32(UserChoice);
            if (UserChoiceInt == 1)
            {
                ReadBalance();
            }
            else if (UserChoiceInt == 3)
            {
                Deposit();
            }


        }
        /// <summary>
        /// This method gives the user the ability to check their balance from the ATM menu. 
        /// </summary>
        public static void ReadBalance()
        {
            Console.WriteLine($"Your balance is {Program.Balance}.");
        }
        /// <summary>
        /// This method gives the user the ability to deposit money to their account from the ATM terminal.
        /// </summary>
        public static void Deposit()
        {
            Console.WriteLine("How much would you like to deposit?");
            string UserDeposit = Console.ReadLine();
            int DepositInt = Convert.ToInt32(UserDeposit);
            if (DepositInt < 0)
            {
                Console.WriteLine("That is not a valid amount.");
                Console.Clear();
                Deposit();
            }
            else
            {
                Balance += DepositInt;
                Console.WriteLine($"Your new balance is {Balance}");
            }
        }
    }
}
