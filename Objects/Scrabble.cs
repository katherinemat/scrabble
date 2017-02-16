using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    private string _input;
    private int _score;

    public Scrabble (string input)
    {
      _input = input;
    }

    public string Score()
    {
      return _input;
    }
  }
}
