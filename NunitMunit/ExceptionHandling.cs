
using System;

public class ExceptionHandling
{
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArithmeticException("Cannot divide by zero.");
        return a / b;
    }
}

using NUnit.Framework;
using System;

[TestFixture]
public class ExceptionHandlingTests
{
    private ExceptionHandling _handler;

    [SetUp]
    public void Setup()
    {
        _handler = new ExceptionHandling();
    }

    [Test]
    public void Divide_ByZero_ShouldThrowArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => _handler.Divide(6, 0));
    }
}


