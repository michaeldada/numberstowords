using System.Collections.Generic;
using System;

namespace NumbersToWordsNS.Objects
{
  public class NumbersToWords
  {
    long _number;
    private static Dictionary<long, string> _oneThruNineteen = new Dictionary<long, string>
    {
      {1, "one"},
      {2, "two"},
      {3, "three"},
      {4, "four"},
      {5, "five"},
      {6, "six"},
      {7, "seven"},
      {8, "eight"},
      {9, "nine"},
      {10, "ten"},
      {11, "eleven"},
      {12, "twelve"},
      {13, "thirteen"},
      {14, "fourteen"},
      {15, "fifteen"},
      {16, "sixteen"},
      {17, "seventeen"},
      {18, "eighteen"},
      {19, "nineteen"}
    };
    private static Dictionary<long, string> _twentyThruNinety = new Dictionary<long, string>
    {
      {20, "twenty"},
      {30, "thirty"},
      {40, "forty"},
      {50, "fifty"},
      {60, "sixty"},
      {70, "seventy"},
      {80, "eighty"},
      {90, "ninety"},

    };


    public NumbersToWords(long number)
    {
      _number = number;

    }

    public Dictionary<long, string> GetOneThruNineteen()
    {
      return _oneThruNineteen;
    }

    public Dictionary<long, string> GetTwentyThruNinety()
    {
      return _twentyThruNinety;
    }


    public string ThreeDigitConvert(long threeDigitNumber)
    {
      string output = "";
      string word;
      long lastTwo = threeDigitNumber%100;
      if (lastTwo>19)
      {
        long tens = lastTwo/10;

      this.GetTwentyThruNinety().TryGetValue(tens*10, out word);
        output += word + " ";
        lastTwo -= tens*10;
      }
      this.GetTwentyThruNinety().TryGetValue(lastTwo, out word);
      output += word;
      this.GetOneThruNineteen().TryGetValue(lastTwo, out word);
      output += word;


      if((threeDigitNumber/100) > 0)
      {
         long hundreds = threeDigitNumber/100;
         this.GetOneThruNineteen().TryGetValue(hundreds, out word);
         output = word + " hundred " + output;
      }
        return output.Trim();
    }


    public string Convert()
    {
      long convertNumber = _number;
      string output = "";
      string billions = "";
      string millions = "";
      string thousands = "";
      long dummyNumber;
      if(convertNumber>1000000000)
      {
        dummyNumber = convertNumber/1000000000;
        billions = this.ThreeDigitConvert(dummyNumber) + " billion ";
        convertNumber = convertNumber%1000000000;
      }

      if(convertNumber>1000000)
      {
        dummyNumber = convertNumber/1000000;
        millions = this.ThreeDigitConvert(dummyNumber) + " million ";
        convertNumber = convertNumber%1000000;
      }

      if(convertNumber>1000)
      {
        dummyNumber = convertNumber/1000;
        thousands = this.ThreeDigitConvert(dummyNumber) + " thousand ";
        convertNumber = convertNumber%1000;
      }

      string lastThree = this.ThreeDigitConvert(convertNumber);

      output = billions + millions + thousands + lastThree;




      return output.Trim();
    }
  }
}
