using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = new[] { "rose" };
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:\r\nrose");

        string expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new[] { "rose", "tulip", "orchid" };
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:\r\nrose");
        sb.AppendLine("Plants with 5 letters:\r\ntulip");
        sb.AppendLine("Plants with 6 letters:\r\norchid");

        string expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseSensitive()
    {
        // Arrange
        string[] input = new[] { "roSE", "tUlip", "ORCHID" };
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Plants with 4 letters:\r\nroSE");
        sb.AppendLine("Plants with 5 letters:\r\ntUlip");
        sb.AppendLine("Plants with 6 letters:\r\nORCHID");

        string expected = sb.ToString().Trim();

        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
