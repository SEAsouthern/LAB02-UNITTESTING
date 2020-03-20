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
            string UserChoice = Console.ReadLine();
            int UserChoiceInt = Convert.ToInt32(UserChoice);
            if (UserChoiceInt == 1)
            {
                ReadBalance();
            }


        }
        /// <summary>
        /// This method gives the user the ability to check their balance from the ATM menu. 
        /// </summary>
        public static void ReadBalance()
        {
            Console.WriteLine($"Your balance is {Program.Balance}.");
        }
    }
}
