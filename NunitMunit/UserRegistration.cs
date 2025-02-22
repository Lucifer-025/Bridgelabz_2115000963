
using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            throw new ArgumentException("All fields are required.");

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            throw new ArgumentException("Invalid email format.");

        if (password.Length < 8)
            throw new ArgumentException("Password must be at least 8 characters long.");
    }
}

using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _userRegistration;

    [SetUp]
    public void Setup()
    {
        _userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInputs_ShouldNotThrowException()
    {
        Assert.DoesNotThrow(() => _userRegistration.RegisterUser("JohnDoe", "john.doe@email.com", "Password123"));
    }

    [Test]
    public void RegisterUser_EmptyUsername_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("", "john.doe@email.com", "Password123"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "invalid-email", "Password123"));
    }

    [Test]
    public void RegisterUser_ShortPassword_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _userRegistration.RegisterUser("JohnDoe", "john.doe@email.com", "12345"));
    }
}

