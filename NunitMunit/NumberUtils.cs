public class NumberUtils
{
    public bool IsEven(int number) => number % 2 == 0;
}

using NUnit.Framework;

[TestFixture]
public class NumberUtilsTests
{
    private NumberUtils _numberUtils;

    [SetUp]
    public void Setup()
    {
        _numberUtils = new NumberUtils();
    }

    [TestCase(2, true)]
    [TestCase(4, true)]
    [TestCase(6, true)]
    [TestCase(7, false)]
    [TestCase(9, false)]
    public void IsEven_ShouldReturnCorrectResult(int number, bool expectedResult)
    {
        Assert.AreEqual(expectedResult, _numberUtils.IsEven(number));
    }
}
