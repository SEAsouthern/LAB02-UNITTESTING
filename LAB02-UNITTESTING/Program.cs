using System;

namespace LAB02_UNITTESTING
{
    public class Program

    {   //Initial balance for ATM program
        static int Balance = 3000;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your Bank");
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Press 1 to Check Balance.");
            Console.WriteLine("Press 2 to Withdraw money.");
            Console.WriteLine("Press 3 to Deposit money.");
            Console.WriteLine("Press 4 to Exit.");
            string UserChoice = Console.ReadLine();
            int UserChoiceInt = Convert.ToInt32(UserChoice);
            if (UserChoiceInt == 1)
            {
                ReadBalance();
            }
            else if (UserChoiceInt == 2)
            {
                Withdraw();
            }
            else if (UserChoiceInt == 3)
            {
                Deposit();
            }
            else if (UserChoiceInt == 4)
            {
                Exit();
            }
        }
        /// <summary>
        /// This method gives the user the ability to check their balance from the ATM terminal. 
        /// </summary>
        public static void ReadBalance()
        {
            Console.WriteLine($"Your balance is {Program.Balance}.");
            Start();
        }

        /// <summary>
        /// This method gives the user the ability to withdraw money from their account from the ATM terminal.
        /// </summary>
        public static void Withdraw()
        {
            Console.WriteLine("How much would you like to withdraw?");
            string UserWithdraw = Console.ReadLine();
            int WithdrawInt = Convert.ToInt32(UserWithdraw);
            if (WithdrawInt < 0)
            {
                Console.WriteLine("That is not a valid amount.");
                Console.Clear();
                Withdraw();
            }
            else
            {
                Balance -= WithdrawInt;
                Console.Clear();
                Console.WriteLine($"Your new balance is {Balance}");
            }
            Start();
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
                Console.Clear();
                Console.WriteLine($"Your new balance is {Balance}");
            }
            Start();
        }

        /// <summary>
        /// This method allows the user to exit the ATM terminal.
        /// </summary>
        public static void Exit()
        {
            Environment.Exit(-1);
        }
    }
}
