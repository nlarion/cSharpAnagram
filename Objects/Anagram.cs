using System;
using System.Linq;
using System.Collections.Generic;

namespace Anagrams

{

//   //variables//
//
    public class Anagram
  {
      private string _inputWord;
      private char[] _arrayWord;

//construtor//

    public Anagram (string inputWord )
    {
     _inputWord = inputWord.ToLower();
     _arrayWord = _inputWord.ToCharArray();
    }


    public List<string> printAnagram(string words){
      List<string> returnList = new List<string> {};
      string[] allWords = words.Split(' ');
      foreach (string word in allWords)
      {
        if (this.IsAnagram(word)){
          returnList.Add(word);
        }
      }
      return returnList;
    }



    public bool IsAnagram(string word)
    {
      if(_inputWord.Length == word.Length)
      {
        word = word.ToLower();
        char[] wordArray = word.ToCharArray();
        Array.Sort(wordArray);
        Array.Sort(_arrayWord);
        return  _arrayWord.SequenceEqual(wordArray);
      }
      else
      {
        return false;
      }
    }
//
//
// //getters and setters for properties//
//
//       public string GetVariable()
//       {
//       return _TEMPLATEVARIABLE;
//       }
//
//       public void SetVariable(string newVariable)
//       {
//         _TEMPLATEVARIABLE = newVariable;
//       }
//
  }
}
