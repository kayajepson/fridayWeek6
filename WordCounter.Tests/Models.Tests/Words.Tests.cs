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
      WordCounter newWord = new WordCounter();
      Assert.AreEqual(true, newWord.IsWord("test"));
    }


  }
}
