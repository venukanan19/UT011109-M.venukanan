//namespace BankingApp
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("=====================");
//            Console.WriteLine("commerical Bank");
//            Console.WriteLine("=====================");
//            Console.WriteLine("Welcome to Our Bank");
//            Console.WriteLine("=====================");

//            Console.WriteLine();//space
//            Console.WriteLine("Please select an option:");
//            Console.WriteLine("1. Check Balance");
//            Console.WriteLine("2. Deposit Funds");
//            Console.WriteLine("3. Withdraw Funds");
//            Console.WriteLine("4. Exit");
//            Console.WriteLine("enter your choice");


//            Console.ReadKey();
//        }
//    }
//}



//namespace BankingApp
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            string bankName = "National Bank";
//            string accountHolder = "John Doe";
//            string accountNumber = "1234567890";
//            decimal accountBalance = 1500.75m;
//            Console.WriteLine("Bank Name: " + bankName);
//            Console.WriteLine("Account Holder Name: " + accountHolder);
//            Console.WriteLine("Account Number: " + accountNumber);
//            Console.WriteLine("Current Balance: " + accountBalance);


//            Console.WriteLine("Enter your name");

//            Console.ReadKey();
//        }
//    }

//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Please enter your name: ");

//        string userName = Console.ReadLine();

//        Console.WriteLine("Hello, " + userName + "welcome");

//        Console.Write("Enter your opening balance: ");
//        string input = Console.ReadLine();
//        decimal openingBalance = Convert.ToDecimal(input);
//        Console.WriteLine($"Your opening balance is: {openingBalance}");

//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {

//        Console.WriteLine("=====================");
//        Console.WriteLine("commerical Bank");
//        Console.WriteLine("=====================");
//        Console.WriteLine("Welcome to Our Bank");
//        Console.WriteLine("=====================");
//        Console.Write("Enter Account Holder Name: ");
//        string holderName = Console.ReadLine();

//        Console.Write("Enter Account Number: ");
//        int accountNumber = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Enter Account Balance: ");
//        decimal balance = decimal.Parse(Console.ReadLine());

//        Console.Clear();


//        Console.WriteLine($"detalis:holdername: {holderName} accountnumber: {accountNumber} balance: {balance}");
//        //Console.WriteLine("Account Details");
//        //Console.WriteLine("----------------");
//        //Console.WriteLine($"Account Holder: {holderName}");
//        //Console.WriteLine($"Account Number: {accountNumber}");
//        //Console.WriteLine($"Balance: {balance}");

//        Console.ReadKey();
//    }
//}



//using System;

//namespace BankingApp
//{
//    internal class Program
//    {
//        static void Main()
//        {


//            static void DisplayWelcomeMessage()
//            {
//                Console.WriteLine("=====================");
//                Console.WriteLine("Commercial Bank");
//                Console.WriteLine("=====================");
//                Console.WriteLine("Welcome to Our Bank");
//                Console.WriteLine("=====================");
//            }

//            DisplayWelcomeMessage();


//            Console.Write("Enter Account Holder Name: ");
//            string holderName = Console.ReadLine();

//            Console.Write("Enter Account Number: ");
//            int accountNumber = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Account Balance: ");
//            decimal balance = decimal.Parse(Console.ReadLine());

//            bool exit = false;

//            while (!exit)
//            {
//                static void DisplayMenu()
//                {
//                    Console.WriteLine("====== Banking Menu ======");
//                    Console.WriteLine("1. View Account");
//                    Console.WriteLine("2. Check Balance");
//                    Console.WriteLine("3. Deposit");
//                    Console.WriteLine("4. Withdraw");
//                    Console.WriteLine("5. Exit");
//                    Console.WriteLine("==========================");
//                }

//                DisplayMenu();

//                Console.Write("Enter your choice: ");
//                int selectedOption = Convert.ToInt32(Console.ReadLine());

//                Console.WriteLine("You selected option: " + selectedOption);
//                switch (selectedOption)
//                {   

//                    case 1:
//                        DisplayAccountDetails(holderName, accountNumber);
//                        break;

//                    case 2:
//                        Console.WriteLine("Checking Balance");
//                        Console.WriteLine("Balance: " + balance);
//                        break;

//                    case 3:

//                        balance = Deposit(balance);
//                        break;

//                    case 4:
//                        balance = Withdraw(balance);
//                        break;


//                    case 5:
//                        Console.WriteLine("Exiting...");
//                        exit = true;
//                        break;

//                    default:
//                        Console.WriteLine("Invalid choice. Please try again.");
//                        break;
//                }


//                if (!exit)
//                {
//                    Console.WriteLine("Press any key to continue...");
//                    Console.ReadKey();

//                    Console.Clear();
//                }
//            }
//        }
//        static void DisplayAccountDetails(string holderName, int accountNumber)
//        {
//            Console.WriteLine("Viewing Account");
//            Console.WriteLine("Username: " + holderName);
//            Console.WriteLine("Account Number: " + accountNumber);
//        }

//        static decimal Deposit(decimal balance)
//        {
//            Console.WriteLine("Depositing Money");
//            Console.Write("Enter your deposit amount: ");
//            decimal deposit = decimal.Parse(Console.ReadLine());
//            if (deposit > 0)
//            {
//                balance += deposit;
//                Console.WriteLine("Your amount is deposited successfully.");
//                Console.WriteLine("Updated Balance: " + balance);
//            }
//            else
//            {
//                Console.WriteLine("Invalid deposit amount.");
//            }
//            return balance;
//        }

//        static decimal Withdraw(decimal balance)
//        {
//            Console.WriteLine("Withdrawing Money");
//            Console.Write("Enter your withdraw amount: ");
//            decimal withdraw = decimal.Parse(Console.ReadLine());
//            if (withdraw > 0 && withdraw <= balance)
//            {
//                balance -= withdraw;
//                Console.WriteLine("Withdrawal successful.");
//                Console.WriteLine("Remaining balance: " + balance);
//            }
//            else
//            {
//                Console.WriteLine("Insufficient balance.");
//            }
//            return balance;
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace BankingApp
{
    class BankAccount
    {
        public string HolderName;
        public int AccountNumber;
        private decimal Balance;

        private List<string> Transactions = new List<string>();

        public BankAccount(string holderName, int accountNumber, decimal balance)
        {
            HolderName = holderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Viewing Account");
            Console.WriteLine("Username: " + HolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Balance: " + Balance);
        }

        public void CheckBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }

        public void Deposit(decimal deposit)
        {
            if (deposit > 0)
            {
                Balance += deposit;
                Transactions.Add($"Deposited: {deposit} | Date: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                Console.WriteLine("Amount deposited successfully.");
                Console.WriteLine("Updated Balance: " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add($"Withdrawn: {amount} | Date: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
                return true;
            }
            return false;
        }

        public void ShowTransactions()
        {
            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transactions yet.");
            }
            else
            {
                Console.WriteLine("Transaction History:");

                foreach (string t in Transactions)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }

    internal class Program
    {
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Commercial Bank");
            Console.WriteLine("=====================");
            Console.WriteLine("Welcome to Our Bank");
            Console.WriteLine("=====================");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("====== Banking Menu ======");
            Console.WriteLine("1. View Account");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Show Transactions");
            Console.WriteLine("6. Exit");
            Console.WriteLine("==========================");
        }

        static void Main()
        {
            DisplayWelcomeMessage();

            Console.Write("Enter Account Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Account Number: ");
            int accountNumber;

            while (!int.TryParse(Console.ReadLine(), out accountNumber))
            {
                Console.WriteLine("Invalid number. Enter again:");
            }

            Console.Write("Enter Account Balance: ");
            decimal balance;

            while (!decimal.TryParse(Console.ReadLine(), out balance))
            {
                Console.WriteLine("Invalid amount. Enter again:");
            }

            BankAccount account = new BankAccount(holderName, accountNumber, balance);

            bool exit = false;

            while (!exit)
            {
                DisplayMenu();

                Console.Write("Enter your choice: ");
                int selectedOption;

                while (!int.TryParse(Console.ReadLine(), out selectedOption))
                {
                    Console.WriteLine("Invalid choice. Enter again:");
                }

                switch (selectedOption)
                {
                    case 1:
                        account.DisplayAccountDetails();
                        break;

                    case 2:
                        account.CheckBalance();
                        break;

                    case 3:
                        Console.Write("Enter deposit amount: ");
                        decimal deposit;

                        while (!decimal.TryParse(Console.ReadLine(), out deposit))
                        {
                            Console.WriteLine("Invalid amount. Enter again:");
                        }

                        account.Deposit(deposit);
                        break;

                    case 4:
                        Console.Write("Enter withdraw amount: ");
                        decimal amount;

                        while (!decimal.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid amount. Enter again:");
                        }

                        if (account.Withdraw(amount))
                            Console.WriteLine("Withdrawal completed.");
                        else
                            Console.WriteLine("Insufficient balance.");
                        break;

                    case 5:
                        account.ShowTransactions();
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

                if (!exit)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}