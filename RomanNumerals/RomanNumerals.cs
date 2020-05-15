using System;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        private const string OneRoman = "I";
        private const string FiveRoman = "V";
        private const string TenRoman = "X";

        public string Convert(int arabicNumber)
        {
            if (arabicNumber == 0) return "";

            if (arabicNumber == 9)
            {
                return OneRoman + TenRoman;
            }

            if (arabicNumber >= 5)
            {
                return FiveRoman + Convert(arabicNumber - 5);
            }

            if (arabicNumber == 4)
            {
                return OneRoman + FiveRoman;
            }

            return OneRoman + Convert(--arabicNumber);
        }
    }
}
