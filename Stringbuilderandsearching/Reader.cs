using System;
using System.IO;
class Reader
{
static void Main()
{
string filepath="Reader.cs";
using(StreamReader st=new StreamReader(filepath))
{
string line;
while((line=st.ReadLine())!=null)
{
Console.WriteLine(line);
}
}
}
}