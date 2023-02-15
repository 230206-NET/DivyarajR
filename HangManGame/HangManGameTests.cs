using System;
using Xunit;

namespace Hangman.Test
{
    public class HangmanGameStart
    {
        [Fact]
        public void HaveTenGuessesAfterInit()
        {
            HangManGame newGame = new HangManGame();
            newGame.InitGame();
            Assert.Equal<int>(10, newGame.lives);
        }
        
        [Fact]
        public void HaveSameLengthForWordAndSecret()
        {
            HangManGame newGame = new HangManGame();
            newGame.InitGame();
            Assert.Equal(newGame.theWord.Length, newGame.secretWord.Length);
        }

        [Fact]
        public void KnowifStringAndCharArrayAreNotSameLength()
        {
            String str = "Hello";
            char[] chars = new char[] { 'h', 'e', 'y' };

            HangManGame newGame = new HangManGame();
            Assert.False(newGame.StringEqualsCharArray(str, chars));
        }

        [Fact]
        public void KnowifStringAndCharArrayAreEqual()
        {
            String str = "Hello";
            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };

            HangManGame newGame = new HangManGame();
            Assert.True(newGame.StringEqualsCharArray(str, chars));
        }

        [Fact]
        public void KnowIfLetterIsInWord()
        {
            HangManGame newGame = new HangManGame();

            newGame.secretWord = "Frog";
            newGame.theWord = new char[4];
            char c = 'r';

            Assert.True(newGame.IsInWord(c));
        }     

    }
}

