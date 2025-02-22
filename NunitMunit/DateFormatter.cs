

using System;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (!DateTime.TryParse(inputDate, out DateTime date))
            throw new FormatException("Invalid date format.");

        return date.ToString("dd-MM-yyyy");
    }
}

using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _formatter;

    [SetUp]
    public void Setup()
    {
        _formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ShouldReturnFormattedDate()
    {
        Assert.AreEqual("22-02-2025", _formatter.FormatDate("2025-02-22"));
    }

    [Test]
    public void FormatDate_InvalidDate_ShouldThrowFormatException()
    {
        Assert.Throws<FormatException>(() => _formatter.FormatDate("invalid-date"));
    }
}

