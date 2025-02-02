using System;

class BankAccount
{
    public string AccountNumber;
    protected string AccountHolder;
    private double Balance;

    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = balance;
    }

    public void SetBalance(double balance)
    {
        Balance = balance;
    }

    public double GetBalance()
    {
        return Balance;
    }
}

class SavingsAccount : BankAccount
{
    public SavingsAccount(string accountNumber, string accountHolder, double balance) : base(accountNumber, accountHolder, balance) { }

    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Savings Account - Number: {AccountNumber}, Holder: {AccountHolder}");
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount("98765", "John", 5000);
        sa.DisplayAccountDetails();
    }
}
