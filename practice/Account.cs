using System;
using System.Collections.Generic;
using System.Text;

namespace practice
{
    public class Account
    {
        
        public int AccountNumber { get; set; }
        public string OwnerName { get; set; }

        public double Balance { get; private set; }

        public AccountType accountType { get; set; }

         public List<Transaction> Transactions { get; set; }

        public Account(int accountnumber,string ownername,double balance,AccountType accountype)
        {
         AccountNumber = accountnumber;
         OwnerName = ownername;
         Balance = balance;
         accountType=accountype;
         Transactions = new List<Transaction>();
        }

        public void Deposit (double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit not completed. Enter a positive number.");
                return;
            }
            Balance += amount;
            Transactions.Add(new Transaction
            {
                Date = DateTime.Now,
                Amount = amount,
                Type = TransactionType.Deposit
            });
            Console.WriteLine("Deposit successful!");
        }

        public bool Withdraw(double amount)
        {
             if (amount <= 0)
            {
                Console.WriteLine("Withdrawal not completed. Enter a positive number");
                return false;
            }
            else if (Balance == 0)

            {
                Console.WriteLine("Withdrawal not completed. Balance is zero.");
                Console.WriteLine($"Current Balance: {Balance}");
                return false;
            }
            
            else if (amount > Balance)
            {
                Console.WriteLine("Withdrawal not completed. Balance is insufficient");
                Console.WriteLine($"Current Balance: {Balance}");
                return false;

            }
            else
            {
                Balance -= amount;
                Transactions.Add(new Transaction
                {
                    Date = DateTime.Now,
                    Amount = amount,
                    Type = TransactionType.Withdrawal
                });
                return true;

                
            }
            
        }

        public void DisplayInfo()
        {
            Console.WriteLine("====================");
            Console.WriteLine("   Account Details  ");
            Console.WriteLine("====================");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Owner Name     : {OwnerName}");
            Console.WriteLine($"Balance        : {Balance:C}"); 
            Console.WriteLine($"Account Type   : {accountType}");
            Console.WriteLine("====================");
        }

         

    }
}
