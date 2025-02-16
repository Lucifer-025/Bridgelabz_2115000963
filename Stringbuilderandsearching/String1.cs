using System;
using System.Text;
class Stringb1
{
    public void Main()
    {
        StringBuilder sb = new StringBuilder("Shivansh");
        StringBuilder sb2 = new StringBuilder("Srivastava");
        sb.Append(sb2);
        Console.WriteLine(sb);
    }
}