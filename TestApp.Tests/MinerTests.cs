using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string[0];

        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[] { "Gold 5", "SILVer 3" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("gold -> 5");
        sb.AppendLine("silver -> 3");

        string expected = sb.ToString().Trim();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        string[] input = new[] { "Gold 5", "SILVer 3", "c0ppEr 2" };
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("gold -> 5");
        sb.AppendLine("silver -> 3");
        sb.AppendLine("c0pper -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
