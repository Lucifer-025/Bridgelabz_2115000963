using System;
class palindrome
{
static void main(String args[])
{
int i,n,m=0,rev=0,orig=0;
Console.Write("Enter the number");
n=int.Parse(Console.ReadLine());
orig=n;
for(i=n;n>0;n=n/10)
{
m=n%10
rev=(rev*10)
}
if(orig==rev)
{
Console.Write("Palindrome number");
}
else
{
Console.Write("Not palindrome number");
}}
}

