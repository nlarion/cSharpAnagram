using Xunit;
namespace  Anagrams.Objects
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
        bool matchWord = newAnagram.IsAnagram("God is awesome!");
        Assert.Equal(true, matchWord);
      }

  }
}
