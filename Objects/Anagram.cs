using System;
using System.Linq;
using System.Collections.Generic;

namespace Anagrams.Objects

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

    public bool IsAnagram(string words)
    {
      char myChar = (char) ' ';
      string[] allWords = words.Split(myChar);
      foreach (string word in allWords)
      {
        if(_inputWord.Length == word.Length)
        {
          string newWord = word.ToLower();
          char[] wordsArray = newWord.ToCharArray();
          Array.Sort(wordsArray);
          Array.Sort(_arrayWord);
          return  _arrayWord.SequenceEqual(wordsArray);
        }
      }
      return false;
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
