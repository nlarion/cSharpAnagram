using Xunit;
using System;
using System.Linq;
using System.Collections.Generic;
namespace  Anagrams
{
  public class AnagramTest
  {

    [Fact]
    public void WordMatcher_ForDogandGod_true()
    {
      Anagram newAnagram = new Anagram("Dog");
      bool matchWord = newAnagram.IsAnagram("God");
      Assert.Equal(true, matchWord);
    }


      [Fact]
      public void SentenceMatcher_ForDogandGod_true()
      {
        Anagram newAnagram = new Anagram("Dog");
        List<string> returnList = newAnagram.printAnagram("God is awesome, dog");
        List<string> testList = new List<string> {"God", "dog"};
        Assert.Equal(testList, returnList);
      }
  }
}
