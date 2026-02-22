
using practice;

class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        int choice;
        
        do
        {
            Console.WriteLine("====================");
            Console.WriteLine("   Welcome to Route Bank  ");
            Console.WriteLine("====================");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. View Account Details");
            Console.WriteLine("5. View Transaction History");
            Console.WriteLine("6. Delete Account");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter your choice: ");

            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
            {
                Console.WriteLine("Enter a valid choice (1-7)");
            }

            switch (choice)
            {
                case 1:
                    bank.CreateAccount();
                    break;
                case 2: // Deposit
                   Console.WriteLine("Enter Account Number: ");
                    int accnumber;
                    while (!int.TryParse(Console.ReadLine(), out accnumber)|| accnumber <0)
                    {
                        Console.WriteLine("Enter A Valid Account Number");
                    }
                    Account account = bank.FindAccount(accnumber);
                    if (account!=null)
                    {
                        Console.WriteLine("Enter Amount: ");
                        double amount;
                        while(!double.TryParse(Console.ReadLine(),out amount))
                        {
                            Console.WriteLine("Enter A Valid Number");
                        }
                        account.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter Account Number: ");
                    
                    while (!int.TryParse(Console.ReadLine(), out accnumber) || accnumber < 0)
                    {
                        Console.WriteLine("Enter A Valid Account Number");
                    }
                    account = bank.FindAccount(accnumber);
                    if (account != null)
                    {
                        Console.WriteLine("Enter Amount: ");
                        double withdrawAmount;
                        while (!double.TryParse(Console.ReadLine(), out withdrawAmount))
                        {
                            Console.WriteLine("Enter A Valid Number");
                        }
                        account.Withdraw(withdrawAmount);
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }
                    break;
                case 4:
               
                    Console.WriteLine("Enter Account Number: ");

                    while (!int.TryParse(Console.ReadLine(), out accnumber) || accnumber < 0)
                    {
                        Console.WriteLine("Enter A Valid Account Number");
                    }
                    account = bank.FindAccount(accnumber);
                    if (account != null)
                    {
                        account.DisplayInfo();
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }

                    break;
                case 5:
                    Console.WriteLine("Enter Account Number: ");
                    while (!int.TryParse(Console.ReadLine(), out accnumber) || accnumber < 0)
                    {
                        Console.WriteLine("Enter A Valid Account Number");
                    }
                    account = bank.FindAccount(accnumber);
                    if (account != null)
                    {
                        if (account.Transactions.Count == 0)
                        {
                            Console.WriteLine("No transactions found.");
                        }
                        else
                        {
                            foreach (Transaction transaction in account.Transactions)
                            {
                                Console.WriteLine(transaction);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }
                    break;
                case 6:
                    
                    Console.WriteLine("Enter Account Number: ");

                    while (!int.TryParse(Console.ReadLine(), out accnumber) || accnumber < 0)
                    {
                        Console.WriteLine("Enter A Valid Account Number");
                    }
                    account = bank.FindAccount(accnumber);
                    if (account != null)
                    {
                        bank.DeleteAccount(accnumber);
                    }
                    else
                    {
                        Console.WriteLine("Account Not Found");
                    }


                    break;
                case 7:
                    Console.WriteLine("Goodbye!");
                    break;
            }

        } while (choice != 7);
    }
}