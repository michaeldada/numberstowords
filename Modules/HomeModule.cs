using Nancy;
using NumbersToWordsNS.Objects;
using System.Collections.Generic;

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
        return View["output.cshtml"];
      };
    }
  }
}
