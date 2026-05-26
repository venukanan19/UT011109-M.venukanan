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
using System.Text.RegularExpressions;

namespace BankingApp
{
    class BankAccount
    {
        public string HolderName;
        public int AccountNumber;
        public decimal Balance;

        public string DOB;
        public string NIC;
        public string Mobile;
        public string Password;

        private List<string> Transactions = new List<string>();

        public BankAccount(string holderName, int accountNumber, decimal balance,
                           string dob, string nic, string mobile, string password)
        {
            HolderName = holderName;
            AccountNumber = accountNumber;
            Balance = balance;
            DOB = dob;
            NIC = nic;
            Mobile = mobile;
            Password = password;

            Transactions.Add($"Account created | {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("===== ACCOUNT DETAILS =====");
            Console.WriteLine("Username: " + HolderName);
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("DOB: " + DOB);
            Console.WriteLine("NIC: " + NIC);
            Console.WriteLine("Mobile: " + Mobile);
            Console.WriteLine("Balance: " + Balance);
        }

        public void CheckBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Transactions.Add($"Deposited: {amount} | {DateTime.Now}");
                Console.WriteLine("Deposit successful.");
            }
            else
            {
                Console.WriteLine("Invalid amount.");
            }
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Transactions.Add($"Withdrawn: {amount} | {DateTime.Now}");
                return true;
            }
            return false;
        }

        public void ShowTransactions()
        {
            Console.WriteLine("===== TRANSACTIONS =====");

            if (Transactions.Count == 0)
            {
                Console.WriteLine("No transactions.");
            }
            else
            {
                foreach (var t in Transactions)
                {
                    Console.WriteLine(t);
                }
            }
        }
    }

    internal class Program
    {
        static List<BankAccount> accounts = new List<BankAccount>();

        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("Commercial Bank");
            Console.WriteLine("=====================");
        }

        static void ShowMainMenu()
        {
            Console.WriteLine("\n1. Login");
            Console.WriteLine("2. Create Account");
            Console.WriteLine("3. Exit");
        }

        static void Main()
        {
            DisplayWelcomeMessage();

            bool exit = false;

            while (!exit)
            {
                ShowMainMenu();

                Console.Write("Enter choice: ");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Enter again:");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Login();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("===== CREATE ACCOUNT =====");
                        CreateAccount();
                        break;

                    case 3:
                        exit = true;
                        Console.WriteLine("Thank you for using Commercial Bank!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void CreateAccount()
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
            {
                Console.WriteLine("Invalid name. Letters only:");
                name = Console.ReadLine();
            }

            Console.Write("Enter Account Number: ");
            int accNo;
            while (!int.TryParse(Console.ReadLine(), out accNo))
            {
                Console.WriteLine("Invalid number:");
            }

            Console.Write("Enter DOB: ");
            string dob = Console.ReadLine();

            Console.Write("Enter NIC: ");
            string nic = Console.ReadLine();

            Console.Write("Enter Mobile: ");
            string mobile = Console.ReadLine();

            Console.Write("Set Password: ");
            string password = Console.ReadLine();

            decimal balance = 1000m;

            BankAccount newAcc = new BankAccount(name, accNo, balance, dob, nic, mobile, password);
            accounts.Add(newAcc);

            Console.WriteLine("Account created successfully!");
            Pause();
        }

        static void Login()
        {
            Console.Write("Enter Username: ");
            string name = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            BankAccount user = accounts
                .FirstOrDefault(a => a.HolderName == name && a.Password == password);

            if (user == null)
            {
                Console.WriteLine("Invalid login. Please create account first.");
                return;
            }

            Console.WriteLine("Login successful!");

            UserMenu(user);
        }

        static void Pause()
        {
            Console.WriteLine("\nPress any key to go back...");
            Console.ReadKey();
            Console.Clear();
        }

        static void UserMenu(BankAccount user)
        {
            bool logout = false;

            while (!logout)
            {
                Console.WriteLine("===== USER MENU =====");
                Console.WriteLine("1. View Account");
                Console.WriteLine("2. Check Balance");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Withdraw");
                Console.WriteLine("5. Transactions");
                Console.WriteLine("6. Logout");

                Console.Write("Enter choice: ");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input:");
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        user.DisplayAccountDetails();
                        Pause();
                        break;

                    case 2:
                        Console.Clear();
                        user.CheckBalance();
                        Pause();
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("Enter deposit: ");
                        decimal dep = decimal.Parse(Console.ReadLine());
                        user.Deposit(dep);

                        Pause();
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write("Enter withdraw: ");
                        decimal w = decimal.Parse(Console.ReadLine());

                        if (user.Withdraw(w))
                            Console.WriteLine("Withdraw successful");
                        else
                            Console.WriteLine("Insufficient balance");

                        Pause();
                        break;

                    case 5:
                        Console.Clear();
                        user.ShowTransactions();

                        Pause();
                        break;

                    case 6:
                        Console.Clear();
                        logout = true;
                        Console.WriteLine("Logged out");

                        Pause();
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
