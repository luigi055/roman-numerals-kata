using System;
using System.Collections.Generic;

namespace RomanNumerals
{
    public class RomanNumeralsMap {
        public string RomanNumeral { get; set; }
        public int PreviousUnit { get; set; }

        public RomanNumeralsMap(string romanNumeral, int previousUnit)
        {
            this.RomanNumeral = romanNumeral;
            this.PreviousUnit = previousUnit;
        }
    }

    public class RomanNumerals
    {
        private Dictionary<int, string> units = new Dictionary<int, string>{
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        public string Convert(int arabicNumber)
        {
            if (arabicNumber == 0) return "";

            var romanNumber = "";

            foreach (var unit in units)
            {
                while (arabicNumber >= unit.Key)
                {
                    romanNumber += unit.Value;
                    arabicNumber -= unit.Key;
                }
            }

            return romanNumber;
        }
    }
}
