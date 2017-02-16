using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    // [Fact]
    // public void InputLetter_OutputLetter_ReturnLetter()
    // {
    //   string userInput = "a";
    //   Scrabble newScrabble = new Scrabble(userInput);
    //   string userOutput = newScrabble.Score();
    //   Console.WriteLine(userOutput);
    //   Assert.Equal("A", userOutput);
    // }
    [Fact]
    public void InputLetter_InputA_ReturnLetterValue()
    {
      string userInput = "a";
      Scrabble newScrabble = new Scrabble(userInput);
      int userOutput = newScrabble.Score();
      Console.WriteLine(userOutput);
      Assert.Equal(1, userOutput);
    }
  }
}
