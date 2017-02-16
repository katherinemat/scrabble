using Nancy;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class Scrabble
  {
    private char[] _input;
    private int _score;
    private char[] _one = {'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T'};
    // private char[] _two = {'D', 'G'};
    // private char[] _three = {'B', 'C', 'M', 'P'};
    // private char[] _four = {'F', 'H', 'V', 'W', 'Y'};
    // private char[] _five = {'K'};
    // private char[] _eight = {'J', 'X'};
    // private char[] _ten = {'Q', 'Z'};

    public Scrabble (string input)
    {
      _input = input.ToUpper().ToCharArray();
      Console.WriteLine(_input);
    }

    public int Score()
    {
        if(_input[0] == _one[0])
        {
            _score += 1;
        }
        return _score;
    }
  }
}
