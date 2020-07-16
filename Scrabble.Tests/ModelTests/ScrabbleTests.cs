using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
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

    [TestMethod]
    public void GameConstructor_HasEmptyList_List()
    {
      string word = "apple";
      Game apple = new Game(word);
      List<String> testList = new List<String>(){};
      CollectionAssert.AreEqual(testList, apple.LetterList);
    }
  } 
}