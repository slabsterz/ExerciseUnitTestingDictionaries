using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{

    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { 1 };

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { 1, 1, 2, 3, 3 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 1");
        sb.AppendLine("3 -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { 1, 1, 2, -3, -3 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("-3 -> 2");
        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { 0, 0, 0, 0, 0 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("0 -> 5");


        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSingleZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { 0 };

        //StringBuilder sb = new StringBuilder();

        //sb.AppendLine("0 -> 1");


        //string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 1"));
    }

    [Test]
    public void Test_Count_WithOnlyNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new[] { -1, -1, -2, -3, -3 };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("-3 -> 2");
        sb.AppendLine("-2 -> 1");
        sb.AppendLine("-1 -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
