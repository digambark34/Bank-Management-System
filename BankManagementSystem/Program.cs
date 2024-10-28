using System;
using System.Collections.Generic;

internal class Account
{
    private double balance;
    public string accountnumber { get; }
    public string ownername { get; }

    public Account(string accountnumber, string ownername)
    {
        this.accountnumber = accountnumber;
        this.ownername = ownername;
        balance = 0.0;
    }

    public void deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Amount Deposited : {amount} New Balance : {balance} ");
        }
        else
        {
            Console.WriteLine("Amount should be positive");
        }
    }

    public void withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Amount withdrawn : {amount} New Balance : {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void checkbalance()
    {
        Console.WriteLine($"Balance in your account is {balance}");
    }
}

internal class Bank
{
    private Dictionary<string, Account> accounts = new Dictionary<string, Account>();

    public void createaccount(string accountnumber, string ownername)
    {
        if (!accounts.ContainsKey(accountnumber))
        {
            accounts[accountnumber] = new Account(accountnumber, ownername);
            Console.WriteLine($"Account has been created successfully for {ownername} with {accountnumber}");
        }
        else
        {
            Console.WriteLine("Account already exists");
        }
    }

    public Account GetAccount(string accountnumber)
    {
        accounts.TryGetValue(accountnumber, out Account account);
        return account;
    }
}

internal class Program
{
    private static void Main()
    {
        Bank bank = new Bank();
        while (true)
        {
            Console.WriteLine("\n1 Create Account");
            Console.WriteLine("2 Deposit Money");
            Console.WriteLine("3 Withdraw Money");
            Console.WriteLine("4 Check Balance");
            Console.WriteLine("5 Exit");
            Console.WriteLine("Choose an Option");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter Account Number");
                    string accountnumber = Console.ReadLine();
                    Console.WriteLine("Enter Owner Name");
                    string ownername = Console.ReadLine();
                    bank.createaccount(accountnumber, ownername);
                    break;

                case "2":
                    Console.WriteLine("Enter Account Number");
                    accountnumber = Console.ReadLine();
                    Account depositaccount = bank.GetAccount(accountnumber);
                    if (depositaccount != null)
                    {
                        Console.WriteLine("Enter Amount to deposit");
                        if (double.TryParse(Console.ReadLine(), out double depositamount))
                        {
                            depositaccount.deposit(depositamount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account not found");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter Account Number");
                    accountnumber = Console.ReadLine();
                    Account withdrawaccount = bank.GetAccount(accountnumber);
                    if (withdrawaccount != null)
                    {
                        Console.WriteLine("Enter Amount to withdraw");

                        if (double.TryParse(Console.ReadLine(), out double withdrawamount))
                        {
                            withdrawaccount.withdraw(withdrawamount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Account not found");
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter Account Number");
                    accountnumber = Console.ReadLine();
                    Account balanceaccount = bank.GetAccount(accountnumber);
                    if (balanceaccount != null)
                    {
                        balanceaccount.checkbalance();
                    }
                    else
                    {
                        Console.WriteLine("Account not Found");
                    }
                    break;

                case "5":
                    Console.WriteLine("Exiting the System");
                    return;

                default:
                    Console.WriteLine("Invalid choice......");
                    break;
            }
        }
    }
}