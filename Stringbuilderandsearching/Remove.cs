using System;
using System.Text;
class Remove
{
    public void remove(StringBuilder sb)
    {
        for (int i = 0; i < sb.Length; i++)
        {
            for (int j = i + 1; j < sb.Length; j++)
            {
                if (sb[i] == sb[j])
                {
                    sb.Remove(j, 1);
                    j--;
                }
            }
        }
    }
	static void Main()
    {
        StringBuilder sb = new StringBuilder("Shivansh");

        Remove re = new Remove();
        re.remove(sb);
        Console.WriteLine(sb.ToString());
    }
}

}