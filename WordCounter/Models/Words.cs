using System;
using System.Collections.Generic;


namespace WordCounter.Words
{
  public class WordCountGen
  {
    public int TimesInSentence (string userWord)
    {
      userWord = userWord.ToLower();
      List<string> sentenceList = new List<string>(){"the", "cat", "in", "the", "hat", "loves", "cathedrals", "and", "cat"};
      int timesAppeared = 0;
      foreach (string i in sentenceList)
        {
          if (i == userWord)
          {
            timesAppeared += 1;
          }
          else
          {
            timesAppeared += 0;
          }
        }
        return timesAppeared;
      }

  public string RemoveNonStringValues (string sentence)
  {
    string userWord = "cat";
    List<string> updatedList = new List<string>(){};
    string[] sentenceArray = sentence.Split();
    for (int i = 0; i <= sentenceArray.Length - 1; i++)
      {
        if ((sentenceArray[i].GetType().GetElementType()) == "String")
        {
          updatedList.Add();
        }
        else
        {
          return false;
        }
      }
  }

// ----if i want an array instead
//
//       public string SentenceToArray(string sentence)
//       {
//         string[] sentenceArray = sentence.Split();
//         return sentenceArray;
//       }
//       public void SentenceContainsWord (string sentence)
//       {
//         string userWord = "cat";
//         string[] sentenceArray = sentence.Split();
//       }
//
//       string[] sentenceArray = {"the", "cat", "in", "the", "hat"};
      // for (int i = 0; i <= sentenceArray.Length - 1; i++)
      // {
      //   if (sentenceArray[i] == userWord)
      //   {
      //     timesAppeared += 1;
      //     Console.WriteLine("working");
      //   }
      //   else
      //   {
      //     Console.WriteLine("not working");
      //     return 0;
      //   }
//       }


    public string WordToLowerCase (string userWord)
    {
      return userWord.ToLower();
    }

    private string _word;
    public bool IsWord(string word)
    {
      _word = word;
      return _word == word;
    }

    private string _sentence;
    public bool IsSentence(string sentence)
    {
      _sentence = sentence;
      return _sentence == sentence;
    }

    public bool SentenceToArray(string sentence)
    {
      string [] _sentenceTest = {"the", "cat", "in", "the", "hat"};
      string[] sentenceArray = sentence.Split();
      string _sentenceString = string.Concat(_sentenceTest);
      string sentenceArrayString = string.Concat(sentenceArray);
      return _sentenceString == sentenceArrayString;
    }

    public bool SentenceContainsWord ()
    {
      string[] sentenceArray = {"the", "cat", "in", "the", "hat"};
      if (((IList<string>)sentenceArray).Contains("cat"))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


  }
}
