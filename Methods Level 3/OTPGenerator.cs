using System;

public class OTPGenerator
{
    public static int GenerateOTP()
    {
        return new Random().Next(100000, 999999);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j]) return false;
            }
        }
        return true;
    }

    public static void Main(string[] args)
    {
        int[] otps = new int[10];
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
        }
        Console.WriteLine(AreOTPsUnique(otps)); // true
    }
}