﻿namespace MoneyTests;

using App.Machine.Types;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void ChangeToCurrency_ChangesAmountAndCurrency()
    {
        // Arrange
        Money wallet = new Money(100, Currency.USD);

        // Act
        wallet.ChangeToCurrency(Currency.EUR);

        // Assert
        Assert.Equal(Currency.EUR, wallet.Currency);
        Assert.Equal(85.0m, wallet.Amount);
    }

    [Fact]
    public void ConvertFromToCurrency_ReturnsNewMoneyWithConvertedAmount()
    {
        // Act
        Money converted = Money.ChangeToCurrency(100, Currency.USD, Currency.JPY);

        // Assert
        Assert.Equal(Currency.JPY, converted.Currency);
        Assert.Equal(11000.0m, converted.Amount);
    }

    [Fact]
    public void ConvertFromToCurrency_NoConversionWhenSameCurrency()
    {
        // Act
        Money converted = Money.ChangeToCurrency(100, Currency.USD, Currency.USD);

        // Assert
        Assert.Equal(Currency.USD, converted.Currency);
        Assert.Equal(100.0m, converted.Amount);
    }
}
