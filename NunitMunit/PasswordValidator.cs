
using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (password.Length < 8)
            return false;

        bool hasUppercase = Regex.IsMatch(password, "[A-Z]");
        bool hasDigit = Regex.IsMatch(password, "\\d");

        return hasUppercase && hasDigit;
    }
}


using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new PasswordValidator();
    }

    [TestCase("Password1", true)]
    [TestCase("short1A", false)]
    [TestCase("alllowercase1", false)]
    [TestCase("ALLUPPERCASE1", true)]
    [TestCase("NoNumber", false)]
    public void IsValid_ShouldReturnExpectedResult(string password, bool expectedResult)
    {
        Assert.AreEqual(expectedResult, _validator.IsValid(password));
    }
}
