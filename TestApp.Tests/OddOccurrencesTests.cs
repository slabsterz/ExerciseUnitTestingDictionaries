using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = OddOccurrences.FindOdd(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new[] { "the", "the", "cat", "cat" };

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new[] { "The" };

        StringBuilder sb = new StringBuilder();

        sb.Append("the");

        string expected = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new[] { "the","the", "the","cat","is" };

        StringBuilder sb = new StringBuilder();

        sb.Append("the ");
        sb.Append("cat ");
        sb.Append("is ");

        string expected = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[] { "The", "thE", "THE", "cat", "IS", "here", "here" };

        StringBuilder sb = new StringBuilder();

        sb.Append("the ");
        sb.Append("cat ");
        sb.Append("is ");

        string expected = sb.ToString().Trim();

        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
