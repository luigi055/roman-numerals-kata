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
        [InlineData(10, "X")]
        [InlineData(20, "XX")]
        [InlineData(30, "XXX")]
        [InlineData(40, "XL")]
        [InlineData(50, "L")]
        [InlineData(60, "LX")]
        [InlineData(70, "LXX")]
        [InlineData(80, "LXXX")]
        [InlineData(90, "XC")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]
        [InlineData(29, "XXIX")]
        [InlineData(294, "CCXCIV")]
        [InlineData(402, "CDII")]
        [InlineData(2019, "MMXIX")]
        public void ConvertArabicNumeralsToRoman(int arabicNumber, string rommanNumber)
        {
            Assert.Equal(rommanNumber, romanNumerals.Convert(arabicNumber));
        }
    }
}
