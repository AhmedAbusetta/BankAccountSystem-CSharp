# 🏦 Bank Account System - C#

A console-based banking system built with C# to practice Object-Oriented Programming concepts.

## 📋 About The Project

This project simulates a simple banking system where a bank employee can manage customer accounts, perform deposits and withdrawals, and view transaction history — all through a console menu.

## ✨ Features

- Create a new bank account
- Deposit money into an account
- Withdraw money from an account (with validation)
- View account details
- View full transaction history
- Delete an account

## 🛠️ Concepts Practiced

- **Encapsulation** — Balance is private and can only be changed through Deposit/Withdraw methods
- **Access Modifiers** — public, private, private set
- **Enums** — AccountType (Savings/Current) and TransactionType (Deposit/Withdrawal)
- **Lists** — `List<Account>` and `List<Transaction>` for dynamic data storage
- **Constructors** — Initializing account data and transaction list
- **Input Validation** — Using `TryParse` and while loops to handle invalid input
- **ToString() Override** — Transaction class formats its own output
- **OOP Design** — Separating responsibilities across Account, Transaction and Bank classes

## 🏗️ Project Structure

```
BankAccountSystem-CSharp/
│
├── Account.cs         # Account class with properties and methods
├── Transaction.cs     # Transaction class with ToString() override
├── Bank.cs            # Bank class managing all accounts
├── Program.cs         # Main menu and entry point
```

## 🚀 How To Run

1. Clone the repository
```bash
git clone https://github.com/yourusername/BankAccountSystem-CSharp.git
```
2. Open in Visual Studio
3. Run the project (`F5` or `Ctrl+F5`)

## 📸 Menu Preview

```
====================
   Welcome to Route Bank
====================
1. Create Account
2. Deposit
3. Withdraw
4. View Account Details
5. View Transaction History
6. Delete Account
7. Exit
Enter your choice:
```

## 🎓 Built While Learning

This project was built as part of my C# OOP learning journey at **Route Academy** — practicing real project-based learning instead of tutorials.

## 📅 Date

February 2026
