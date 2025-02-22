public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }
}

using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_ShouldReturnCorrectSum()
    {
        Assert.AreEqual(5, _calculator.Add(2, 3));
    }

    [Test]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        Assert.AreEqual(1, _calculator.Subtract(3, 2));
    }

    [Test]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.AreEqual(6, _calculator.Multiply(2, 3));
    }

    [Test]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.AreEqual(2, _calculator.Divide(6, 3));
    }

    [Test]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
    }
}


