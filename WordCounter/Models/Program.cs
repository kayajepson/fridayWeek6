using System;

namespace WordCounter.Words
{
  public class WordCounterProgram
  {
    public static void Main()
    {
      WordCountGen newWord = new WordCountGen();
      newWord.SentenceContainsWord("the cat in the hat");
      newWord.TimesInSentence("cat");
      Console.WriteLine(newWord.TimesInSentence("cat"));
      // Console.WriteLine("Please enter a word: ");
      // string userWord = Console.ReadLine().ToLower();
      // Console.WriteLine("Please enter a sentence: ");
      // string userSentence = Console.ReadLine().ToLower();
      // int wordScore = newScore.LoopThroughWord(scrabbleWord);
      // Console.WriteLine("Your word appears in the sentence" + " " + wordScore + " " +  "times.");

    }
  }
}
