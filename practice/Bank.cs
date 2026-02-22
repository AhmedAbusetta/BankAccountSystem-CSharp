using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;

namespace practice
{
   
    public class Bank
    {
        private List<Account> Accounts;
        private int lastAccountNumber;

        public Bank()
        {
            Accounts = new List<Account>();
            lastAccountNumber = 1000;
        }

        public void CreateAccount()
        {
            
            Console.WriteLine("Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your Balance: ");
            double balance;
            while (!double.TryParse(Console.ReadLine(), out balance) || balance < 0)
            {
                Console.WriteLine("Enter a valid balance");
            }
            Console.WriteLine("Enter Account Type ( 0 [Current] ,1 [Saving] ): ");
            int type;
            while (!int.TryParse(Console.ReadLine(), out type) || type < 0 || type >1)
            {
                Console.WriteLine("Enter a Valid Account type 1 or 2 ");
            }
            AccountType accountType = (AccountType) type;

   
            lastAccountNumber++;


            Account accounts = new Account(lastAccountNumber,name,balance,accountType);
            Accounts.Add(accounts);
            Console.WriteLine($"Account created successfully! Account Number: {lastAccountNumber}");
        }

        public Account FindAccount(int accountNumber)
        {
            foreach (Account account in Accounts)
            {
                if (account.AccountNumber == accountNumber) 
                {
                    return account; 
                }
            }
            return null;
        }


        public void DeleteAccount(int accountNumber)
        {
            Account account = FindAccount(accountNumber);
            if (account != null)
            {
                Accounts.Remove(account);
                Console.WriteLine($"Account {accountNumber} deleted successfully!");
            }
            else
            {
                Console.WriteLine("Account Was Not Found");
            }
        }

        public void DisplayAllAccounts()
        {
            if (Accounts.Count == 0)
            {
                Console.WriteLine("No accounts found.");
                return;
            }
            foreach (Account account in Accounts)
            {
                account.DisplayInfo();
            }
        }
    }
    
}
