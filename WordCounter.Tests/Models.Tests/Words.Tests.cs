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
    public void WordToLowerCase_TurnWordToLowerCase()
    {
      WordCountGen newSentence = new WordCountGen();
      Assert.AreEqual("the cat in the hat", newSentence.SentenceToLowerCase("The CAT in the Hat"));
    }

    [TestMethod]
    public void SentenceToArray_UserSentenceToArray_True()
    {
      WordCountGen newArray = new WordCountGen();
      Assert.AreEqual(true, newArray.SentenceToArray("the cat in the hat"));
    }

    [TestMethod]
    public void SentenceContainsWord_UserSentenceContainsUserWord_True()
    {
      WordCountGen newComparison = new WordCountGen();
      Assert.AreEqual(true, newComparison.SentenceContainsWord());
    }

    [TestMethod]
    public void WordInSentence_RepeatCounter()
    {
      WordCountGen newComparison = new WordCountGen();
      Assert.AreEqual(2, newComparison.RepeatCounter("cat"));
    }

    [TestMethod]
    public void LetterIsLetter_RemoveNonAlphabet()
    {
      WordCountGen newComparison = new WordCountGen();
      Assert.AreEqual(true, newComparison.RemoveNonAlphabet('c'));
    }

  }
}
