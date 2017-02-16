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
    private char[] _two = {'D', 'G'};
    private char[] _three = {'B', 'C', 'M', 'P'};
    private char[] _four = {'F', 'H', 'V', 'W', 'Y'};
    private char[] _five = {'K'};
    private char[] _eight = {'J', 'X'};
    private char[] _ten = {'Q', 'Z'};

    public Scrabble (string input)
    {
      _input = input.ToUpper().ToCharArray();
    }

    public int Score()
    {
        for (int j = 0; j < _input.Length; j++)
        {
            for(int i = 0; i < _one.Length; i++)
            {
                if(_input[j] == _one[i])
                {
                    _score += 1;
                }
            }
            for(int o = 0; o < _two.Length; o++)
            {
                if(_input[j] == _two[o])
                {
                    _score += 2;
                }
            }
            for(int p = 0; p < _three.Length; p++)
            {
                if(_input[j] == _three[p])
                {
                    _score += 3;
                }
            }
            for(int q = 0; q < _four.Length; q++)
            {
                if(_input[j] == _four[q])
                {
                    _score += 4;
                }
            }
            for(int g = 0; g < _five.Length; g++)
            {
                if(_input[j] == _five[g])
                {
                    _score += 5;
                }
            }
            for(int k = 0; k < _eight.Length; k++)
            {
                if(_input[j] == _eight[k])
                {
                    _score += 8;
                }
            }
            for(int h = 0; h < _ten.Length; h++)
            {
                if(_input[j] == _ten[h])
                {
                    _score += 10;
                }
            }
        }
        return _score;
    }
  }
}
