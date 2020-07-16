using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Game
  {
    public string UserWord {get; set;} // auto-implemented property

    public Game(string userWord)
    {
      UserWord = userWord;
      //List<String> letterList = new List<String> {"a"};
    }

  }
}