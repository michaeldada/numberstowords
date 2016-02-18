using System.Collections.Generic;
using Xunit;
namespace NumbersToWordsNS.Objects
{
  public class NumbersToWordsTest
  {
    [Fact]
    public void NumbersToWords_1_one()
    {
      NumbersToWords test = new NumbersToWords(1);
      Assert.Equal("one", test.Convert());
    }
    [Fact]
    public void NumbersToWords_12_twelve()
    {
      NumbersToWords test = new NumbersToWords(12);
      Assert.Equal("twelve", test.Convert());
    }
    [Fact]
    public void NumbersToWords_90_ninety()
    {
      NumbersToWords test = new NumbersToWords(90);
      Assert.Equal("ninety", test.Convert());
    }
    [Fact]
    public void NumbersToWords_99_ninetynine()
    {
      NumbersToWords test = new NumbersToWords(99);
      Assert.Equal("ninety nine", test.Convert());
    }
    [Fact]
    public void NumbersToWords_100_onehundred()
    {
      NumbersToWords test = new NumbersToWords(100);
      Assert.Equal("one hundred", test.Convert());
    }
    [Fact]
    public void NumbersToWords_505_fivehundredfive()
    {
      NumbersToWords test = new NumbersToWords(505);
      Assert.Equal("five hundred five", test.Convert());
    }
    [Fact]
    public void NumbersToWords_999_ninehundredninetynine()
    {
      NumbersToWords test = new NumbersToWords(999);
      Assert.Equal("nine hundred ninety nine", test.Convert());
    }
    [Fact]
    public void NumbersToWords_5500_fivethousandgivehundred()
    {
      NumbersToWords test = new NumbersToWords(5500);
      Assert.Equal("five thousand five hundred", test.Convert());
    }
    [Fact]
    public void NumbersToWords_999999_ninehundredninetyninethousandninehundredninetynine()
    {
      NumbersToWords test = new NumbersToWords(999999);
      Assert.Equal("nine hundred ninety nine thousand nine hundred ninety nine", test.Convert());
    }
    [Fact]
    public void NumbersToWords_5000005_fivemillionfive()
    {
      NumbersToWords test = new NumbersToWords(5000005);
      Assert.Equal("five million five", test.Convert());
    }
    [Fact]
    public void NumbersToWords_900009_ninehundredthousandnine()
    {
      NumbersToWords test = new NumbersToWords(900009);
      Assert.Equal("nine hundred thousand nine", test.Convert());
    }
    [Fact]
    public void NumbersToWords_999099_ninehundredninetyninethousandninetynine()
    {
      NumbersToWords test = new NumbersToWords(999099);
      Assert.Equal("nine hundred ninety nine thousand ninety nine", test.Convert());
    }
    [Fact]
    public void NumbersToWords_5555555_fivehundredfiftyfivemillionfivehundredfiftyfivethousandfivehundredfiftyfive()
    {
      NumbersToWords test = new NumbersToWords(555555555);
      Assert.Equal("five hundred fifty five million five hundred fifty five thousand five hundred fifty five", test.Convert());
    }
  }
}
