using System;
using System.Collections.Generic;

namespace Scrabble
{
  public class Game
  {
    public string UserWord {get; set;} // auto-implemented property
    public List<String> LetterList {get; set;}
    public Game(string userWord)
    {
      UserWord = userWord;
      LetterList = new List<String>() {};
    }

  }
}