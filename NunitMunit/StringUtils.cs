
using System;

public class StringUtils
{
    public string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }

    public string ToUpperCase(string str) => str.ToUpper();
}

using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _stringUtils;

    [SetUp]
    public void Setup()
    {
        _stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_ShouldReturnReversedString()
    {
        Assert.AreEqual("tac", _stringUtils.Reverse("cat"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnTrueForPalindrome()
    {
        Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
    }

    [Test]
    public void IsPalindrome_ShouldReturnFalseForNonPalindrome()
    {
        Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
    }

    [Test]
    public void ToUpperCase_ShouldConvertToUpperCase()
    {
        Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello"));
    }
}

