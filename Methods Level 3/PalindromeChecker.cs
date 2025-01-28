using System;

class PalindromeChecker
{
    static void Main(string[] args)
    {
        string str = "madam"; // Example string
        Console.WriteLine("String: " + str);

        if (IsPalindrome(str))
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }

    static bool IsPalindrome(string str)
    {
        int left = 0, right = str.Length - 1;
        while (left < right)
        {
            if (str[left] != str[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
