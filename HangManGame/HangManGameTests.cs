using System;
using Xunit;

namespace Hangman.Test
{
    public class HangmanGameStart
    {
        public void HaveTenGuessesAfterInit()
        {
            HangmanGame newGame = new HangmanGame();
            newGame.InitGame();
            Assert.Equal<int>(10, newGame.lives);
        }

        [Fact]
        public void HaveSameLengthForWordAndSecret()
        {
            HangmanGame newGame = new HangmanGame();
            newGame.InitGame();
            Assert.Equal(newGame.theWord.Length, newGame.secretWord.Length);
        }

        [Fact]
        public void KnowifStringAndCharArrayAreNotSameLength()
        {
            String str = "Hello";
            char[] chars = new char[] { 'h', 'e', 'y' };

            HangmanGame newGame = new HangmanGame();
            Assert.False(newGame.StringEqualsCharArray(str, chars));
        }

        [Fact]
        public void KnowifStringAndCharArrayAreEqual()
        {
            String str = "Hello";
            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };

            HangmanGame newGame = new HangmanGame();
            Assert.True(newGame.StringEqualsCharArray(str, chars));
        }

        [Fact]
        public void KnowIfLetterIsInWord()
        {
            HangmanGame newGame = new HangmanGame();

            newGame.secretWord = "Frog";
            newGame.theWord = new char[4];
            char c = 'r';

            Assert.True(newGame.IsInWord(c));
        }     

    }
}

