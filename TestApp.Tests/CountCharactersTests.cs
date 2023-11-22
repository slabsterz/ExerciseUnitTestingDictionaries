﻿using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

   
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new() { "a" };

        //Act
        string result = CountCharacters.Count(input);

        //Assert
        Assert.That(result, Is.EqualTo("a -> 1"));

    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new() { "aha", "aha", "mhm" };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("a -> 4");
        stringBuilder.AppendLine("h -> 3");
        stringBuilder.AppendLine("m -> 2");        

        string expected = stringBuilder.ToString().Trim();

        //Act
        string result = CountCharacters.Count(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        //Arrange
        List<string> input = new() { "a?h?a", "aha!!", "mhm." };

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("a -> 4");
        stringBuilder.AppendLine("? -> 2");
        stringBuilder.AppendLine("h -> 3");
        stringBuilder.AppendLine("! -> 2");
        stringBuilder.AppendLine("m -> 2");       
        stringBuilder.AppendLine(". -> 1");

        string expected = stringBuilder.ToString().Trim();

        //Act
        string result = CountCharacters.Count(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
