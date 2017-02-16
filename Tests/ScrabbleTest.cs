using Xunit;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Objects
{
  public class ScrabbleTest
  {
    [Fact]
    public void InputLetter_OutputLetter_ReturnLetter()
    {
      string userInput = "a";
      Scrabble newScrabble = new Scrabble(userInput);
      string userOutput = newScrabble.Score();
      Assert.Equal("a", userOutput);
    }
  }
}
