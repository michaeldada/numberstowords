using Nancy;
using NumbersToWordsNS.Objects;
using System.Collections.Generic;
using System;

namespace NumbersToWordsNS.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ => {
        long outputlong = long.Parse(Request.Form["number"]);
        NumbersToWords newNumbersToWords = new NumbersToWords(outputlong);
        string output = newNumbersToWords.Convert();
        return View["output.cshtml", output];
      };
    }
  }
}
