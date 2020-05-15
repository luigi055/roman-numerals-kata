using System;
using Xunit;
using RomanNumerals;

namespace RomanNumerals.Test.Unit
{
  public class RomanNumeralsShould
  {
    [Fact]
    public void ConvertOneToI()
    {
      var romanNumerals = new RomanNumerals();

      var converted = romanNumerals.Convert(1);

      Assert.True(converted == "I");
    }
    [Fact]
    public void ConvertTwoToII()
    {
      var romanNumerals = new RomanNumerals();

      var converted = romanNumerals.Convert(2);

      Assert.True(converted == "II");
    }
    [Fact]
    public void ConvertThreeToIII()
    {
      var romanNumerals = new RomanNumerals();

      var converted = romanNumerals.Convert(3);

      Assert.True(converted == "III");
    }

    [Fact]
    public void ConvertFourToIV()
    {
      var romanNumerals = new RomanNumerals();

      var converted = romanNumerals.Convert(4);

      Assert.True(converted == "IV");
    }
  }
}
