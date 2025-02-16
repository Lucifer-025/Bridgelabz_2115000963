using System;
using System.Text;
class Stringbuil
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello");
        Console.WriteLine(sb);
        int n=sb.Length;
        for(int i=0; i<n/2; i++)
        {
            char temp=sb[i];
            sb[i] = sb[n-i-1];
            sb[n-i-1] = temp;
        }
        Console.WriteLine(sb.ToString());
    }
}