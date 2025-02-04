using System;
class BankAccount
{
    private static int totalAccounts = 0;
    public static string bankName = "Global Bank";
    private readonly int AccountNumber;
    public string AccountHolderName;
	public BankAccount(string accountHolderName, int accountNumber)
	{ 
	this.AccountHolderName=accountHolderName;
	this.AccountNumber=accountNumber;
	totalAccounts++;
	}
	
	public void GetTotalAccounts()
	{
	Console.WriteLine("Total Accounts :"+totalAccounts):
	}
	public void displayaccountdetails()
	{
	if(this is BankAccount)
	{
	Console.WriteLine("Bank :"+bankName);
	Console.WriteLine("AccountHolderName :"+AccountHolderName);
	Console.WriteLine("AccountNumber :"+AccountNumber);
	}
	}
	static void Main()
	{
	BankAccount user1=new BankAccount();
	BankAccount user2=new BankAccount();
	user1.displayaccountdetails();
	user2.displayaccountdetails();
	BankAccount.GetTotalAccounts();
	}
	}