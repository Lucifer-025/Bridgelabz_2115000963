using System;
class Employee
{
	private string name;
	private int id;
	private double salary;
	public void details()
	{
		Console.WriteLine("Enter name");
		name=Console.ReadLine();
		Console.WriteLine("Enter id");
		id=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter salary");
		salary=double.Parse(Console.ReadLine());
	}
	public void displaydetails()
	{
		Console.WriteLine("\nEmployee Details");
		Console.WriteLine("Name :"+name);
		Console.WriteLine("ID :"+id);
		Console.WriteLine("Salary :"+ salary);
		
	}
	static void Main()
	{
		Employee emp=new Employee();
		emp.details();
		emp.displaydetails();
	}
}