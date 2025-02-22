
public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

    public double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;
}

using NUnit.Framework;

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter _converter;

    [SetUp]
    public void Setup()
    {
        _converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ShouldConvertCorrectly()
    {
        Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0));
        Assert.AreEqual(98.6, _converter.CelsiusToFahrenheit(37), 0.1);
    }

    [Test]
    public void FahrenheitToCelsius_ShouldConvertCorrectly()
    {
        Assert.AreEqual(0, _converter.FahrenheitToCelsius(32));
        Assert.AreEqual(37, _converter.FahrenheitToCelsius(98.6), 0.1);
    }
}


