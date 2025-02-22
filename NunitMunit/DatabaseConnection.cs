using System;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; }

    public void Connect() => IsConnected = true;

    public void Disconnect() => IsConnected = false;
}

using NUnit.Framework;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _db;

    [SetUp]
    public void Setup()
    {
        _db = new DatabaseConnection();
        _db.Connect();
    }

    [TearDown]
    public void Teardown()
    {
        _db.Disconnect();
    }

    [Test]
    public void Connect_ShouldEstablishConnection()
    {
        Assert.IsTrue(_db.IsConnected);
    }

    [Test]
    public void Disconnect_ShouldCloseConnection()
    {
        _db.Disconnect();
        Assert.IsFalse(_db.IsConnected);
    }
}
