
using System.Collections.Generic;

public class ListManager
{
    public void AddElement(List<int> list, int element) => list.Add(element);

    public void RemoveElement(List<int> list, int element) => list.Remove(element);

    public int GetSize(List<int> list) => list.Count;
}

using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager _listManager;
    private List<int> _list;

    [SetUp]
    public void Setup()
    {
        _listManager = new ListManager();
        _list = new List<int>();
    }

    [Test]
    public void AddElement_ShouldIncreaseListSize()
    {
        _listManager.AddElement(_list, 1);
        Assert.AreEqual(1, _listManager.GetSize(_list));
    }

    [Test]
    public void RemoveElement_ShouldDecreaseListSize()
    {
        _listManager.AddElement(_list, 1);
        _listManager.RemoveElement(_list, 1);
        Assert.AreEqual(0, _listManager.GetSize(_list));
    }
}
