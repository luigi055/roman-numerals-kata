using System;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        private const string OneRoman = "I";
        private const string FiveRoman = "V";

        public string Convert(int number)
        {
            if (number == 0) return "";

            if (number == 5) return FiveRoman;

            if (number == 4)
            {
                return OneRoman + FiveRoman;
            }

            if (number >= 6)
            {
                return Convert(--number) + OneRoman;
            }

            return OneRoman + Convert(--number);
        }
    }
}
