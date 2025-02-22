
using System;
using System.IO;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
            throw new FileNotFoundException("File not found.");
        return File.ReadAllText(filename);
    }
}

using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor _fileProcessor;
    private string _testFile = "testfile.txt";

    [SetUp]
    public void Setup()
    {
        _fileProcessor = new FileProcessor();
    }

    [TearDown]
    public void Teardown()
    {
        if (File.Exists(_testFile))
        {
            File.Delete(_testFile);
        }
    }

    [Test]
    public void WriteToFile_ShouldCreateFileWithContent()
    {
        _fileProcessor.WriteToFile(_testFile, "Hello, World!");
        Assert.IsTrue(File.Exists(_testFile));
        Assert.AreEqual("Hello, World!", File.ReadAllText(_testFile));
    }

    [Test]
    public void ReadFromFile_ShouldReturnFileContent()
    {
        File.WriteAllText(_testFile, "Test Content");
        string content = _fileProcessor.ReadFromFile(_testFile);
        Assert.AreEqual("Test Content", content);
    }

    [Test]
    public void ReadFromFile_NonExistentFile_ShouldThrowFileNotFoundException()
    {
        Assert.Throws<FileNotFoundException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
    }
}


