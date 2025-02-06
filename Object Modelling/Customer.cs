using System;
using System.Collections.Generic;

class Customer
{
    public string Name;
    public List<BankAccount> Accounts = new List<BankAccount>();

    public Customer(string name)
    {
        this.Name = name;
    }

    public void AddAccount(BankAccount account)
    {
        Accounts.Add(account);
    }

    public void ViewBalance()
    {
        Console.WriteLine("Customer :" +Name);
        foreach (var acc in Accounts)
        {
            Console.WriteLine("Account :"+acc.AccountNumber); 
			Console.WriteLine("Balance :"+acc.Balance);
        }
    }
}

class BankAccount
{
    public string AccountNumber;
    public double Balance;

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.AccountNumber = accountNumber;
        this.Balance = initialBalance;
    }

    public void Deposit(double amount) {
	Balance += amount;
}
}

class Bank
{
    public string Name;
    private List<Customer> customers = new List<Customer>();

    public Bank(string name)
    {
        this.Name = name;
    }

    public void OpenAccount(Customer customer, BankAccount account)
    {
        customer.AddAccount(account);
        customers.Add(customer);
    }
}

class Program
{
    static void Main()
    {
        Bank bank = new Bank("State Bank Of India");
        Customer customer = new Customer("Shivansh");
        BankAccount account = new BankAccount("12345", 5000);

        bank.OpenAccount(customer, account);
        customer.ViewBalance();
    }
}
