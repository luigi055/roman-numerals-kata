using System;

namespace RomanNumerals
{


  public class RomanNumerals
  {
    private const string OneRoman = "I";

    public string Convert(int number)
    {

      if (number == 0) return "";
      if (number == 4)
      {

        return "IV";
      }

      return OneRoman + Convert(number - 1);
    }
  }
}
