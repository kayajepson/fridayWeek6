using System;
using System.Collections.Generic;

namespace WordCounter.Words
{
  public class WordCountGen
  {
    // public string SentenceToArray(string sentence)
    // {
    //   string[] sentenceArray = sentence.Split();
    //   return sentenceArray;
    // }
    public void SentenceContainsWord (string sentence)
    {
      string userWord = "cat";
      string[] sentenceArray = sentence.Split();
      if (((IList<string>)sentenceArray).Contains(userWord))
      {
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("False");
      }
    }

//------------------------------------------------
    // private string _word;
    // public bool IsWord(string word)
    // {
    //   _word = word;
    //   return _word == word;
    // }
    //
    // private string _sentence;
    // public bool IsSentence(string sentence)
    // {
    //   _sentence = sentence;
    //   return _sentence == sentence;
    // }
    //
    // public bool SentenceToArray(string sentence)
    // {
    //   string [] _sentenceTest = {"the", "cat", "in", "the", "hat"};
    //   string[] sentenceArray = sentence.Split();
    //   string _sentenceString = string.Concat(_sentenceTest);
    //   string sentenceArrayString = string.Concat(sentenceArray);
    //   return _sentenceString == sentenceArrayString;
    // }
    //
    // public bool SentenceContainsWord ()
    // {
    //   string[] sentenceArray = {"the", "cat", "in", "the", "hat"};
    //   if (((IList<string>)sentenceArray).Contains("cat"))
    //   {
    //     return true;
    //   }
    //   else
    //   {
    //     return false;
    //   }
    // }


  }
}
