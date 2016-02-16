using Nancy;
using System.Collections.Generic;
using Xunit;
using System;
using System.Linq;

namespace Anagrams
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];


      Post["/"] = _ => {
      Anagram newAnagram = new Anagram(Request.Form["word"]);
      List<string> returnList = newAnagram.printAnagram(Request.Form["listWords"]);
      return View["index.cshtml", returnList];
      };
    }
  }
}
