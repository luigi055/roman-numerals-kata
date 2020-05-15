using Xunit;

namespace RomanNumerals.Test.Unit
{
    public class RomanNumeralsShould
    {
        private RomanNumerals romanNumerals = new RomanNumerals();

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        public void ConvertArabicNumeralsToRoman(int arabicNumber, string rommanNumber)
        {
            Assert.Equal(rommanNumber, romanNumerals.Convert(arabicNumber));
        }
    }
}
