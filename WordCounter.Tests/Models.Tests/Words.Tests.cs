using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Words;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWord_IsAWord_True()
    {
      WordCountGen newWord = new WordCountGen();
      Assert.AreEqual(true, newWord.IsWord("test"));
    }
    [TestMethod]
    public void IsSentence_IsASentence_True()
    {
      WordCountGen newSentence = new WordCountGen();
      Assert.AreEqual(true, newSentence.IsSentence("the cat in the hat"));
    }

    [TestMethod]
    public void SentenceToArray_UserSentenceToArray_True()
    {
      WordCountGen newArray = new WordCountGen();
      Assert.AreEqual(true, newArray.SentenceToArray("the cat in the hat"));
    }
    //
    // [TestMethod]
    // public void WorthOne_LetterAEqualsOne_True()
    // {
    //   ScrabbleScore newWord = new ScrabbleScore();
    //   Assert.AreEqual(1,  newWord.LookUpValue('a'));
    // }
    //
    // [TestMethod]
    // public void WorthFive_WordEqualsFive_True()
    // {
    //   ScrabbleScore newWord = new ScrabbleScore();
    //   Assert.AreEqual(5,  newWord.LoopThroughWord("dad"));
    // }

  }
}
