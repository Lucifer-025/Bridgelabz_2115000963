using System;
class Employee
{
    private static int totalemployees = 0;
    public static string CompanyName = "CAPGEMINI";
    private readonly int ID;
    public string Name;
	public string Designation;
	public Employee(string name,string designation, int id)
	{ 
	this.Name=name;
	this.Designation=designation;
	this.ID=id;
	totalemployees++;
	}
	
	public static void DisplayTotalEmployees()
	{
	Console.WriteLine("Total Employees :"+totalemployees);
	}
	public void displayemployeesdetails()
	{
	if(this is Employee)
	{
	Console.WriteLine("Company :"+CompanyName);
	Console.WriteLine("Employee Name :"+Name);
	Console.WriteLine("Designation :"+Designation);
	Console.WriteLine("ID :"+ID);
	}
	}
	static void Main()
	{
	Employee employee1=new Employee("Shivansh","Senior Analyst",115963);
	Employee employee2=new Employee("Rahul","Analyst",125486);
	employee1.displayemployeesdetails();
	employee2.displayemployeesdetails();
	Employee.DisplayTotalEmployees();
	}
	}