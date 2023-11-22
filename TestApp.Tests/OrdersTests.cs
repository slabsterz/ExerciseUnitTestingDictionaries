using System;
using System.Text;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = new string[0];

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[] { "Beer 1.20 10", "Oranges 2.20 5" };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Beer -> 12.00");
        sb.AppendLine("Oranges -> 11.00");

        string expected = sb.ToString().Trim();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[] { "Beer 9.846 3", "Oranges 5.452 3" };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Beer -> 29.54");
        sb.AppendLine("Oranges -> 16.36");

        string expected = sb.ToString().Trim();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new[] { "Beer 9.845 8.2", "Oranges 5.452 2.114" };

        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Beer -> 80.73");
        sb.AppendLine("Oranges -> 11.53");

        string expected = sb.ToString().Trim();

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
