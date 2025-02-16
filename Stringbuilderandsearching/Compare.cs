using System;
using System.Text;
{
class Compare
static void Main()
{
StringBuilder sb=new StringBuilder("Bye");
StringBuilder sb1=new StringBuilder("Bye");
StringBuilder sb2=new StringBuilder("Hii");


Console.WriteLine(sb.ToString().Equals(sb1.ToString()));
Console.WriteLine(sb.ToString().Equals(sb2.ToString()));
}
}