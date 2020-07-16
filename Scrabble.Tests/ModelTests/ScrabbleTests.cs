using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("thinghere");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_HasUserWordField_String()
    {
      string word = "apple";
      Game apple = new Game(word); //"apple"
      Assert.AreEqual("apple", apple.UserWord);
    }
  } 
}