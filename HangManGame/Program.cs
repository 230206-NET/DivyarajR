using System;
using System.Text;

namespace Hangman
{
    public class HangmanGame
    {
        public static void main(string[] args)
        {

            Console.WriteLine("Welcome to Hangman!");
            HangmanGame newGame = new HangmanGame();
            newGame.InitGame();
            newGame.PlayGame();
        }
        public String[] words = new String[] {"coffee", "banana", "airport", "cryptography", "computer"};
        public int lives; //lives remaining for user once game starts
        public StringBuilder? lettersUsed; //dynamic object to maintain the letters already guessed

        public String? secretWord; //word to be guessed
        public char[]? theWord; //correct word

        public bool keepAlive = true;
        
        //initializing game
        public void InitGame()
        {
            lives = 10;
            lettersUsed = new StringBuilder();
            Random rand = new Random();
            int wordIndex = rand.Next(0, words.Length);
            secretWord = words[wordIndex];         
            theWord = new char[secretWord.Length];
            for (int i = 0; i < theWord.Length; i++)
            {
                theWord[i] = '_';

            }
        }

        //method to start the game
        //where the user has to guess letter/word ocorrectly with number of lives
        public void PlayGame()
        {
            while (keepAlive)
            {
                PrintStatus();
                Console.WriteLine("Press W to guess a word, L to guess a letter or Q to quit:");
                String choice = Console.ReadLine() ?? string.Empty;
                String action = choice.ToUpper();
                switch (action)
                {
                    case "W":
                        Console.WriteLine("Which word do you think is right?");
                        String guessedWord = Console.ReadLine() ?? string.Empty;
                        GuessWord(guessedWord.ToLower());
                        break;
                    case "L":
                        Console.WriteLine("Which letter would you like to guess for?");
                        String guessedLetter = Console.ReadLine() ?? string.Empty;
                        char letter = guessedLetter[0];
                        GuessLetter(letter);
                        break;
                    case "Q":
                        Console.WriteLine("Thank you for playing!");
                        keepAlive = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }
                if (lives == 0)
                {
                    Console.WriteLine("You have no more guesses! Game over.");
                    EndOfGame();
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        //method to determine the number of lives the user has
        public void PrintStatus()
        {
            Console.WriteLine("You have " + lives + " guesses left.");
            Console.WriteLine("you have guessed the following letters: " + lettersUsed);
            Console.WriteLine(theWord);
        }
        
        //word guessed correctly by the player with n lives remaining
        void GuessWord(String word)
        {
            lives--;
            if (word.Equals(secretWord))
            {
                Console.WriteLine("Congratulations! You have guessed the right word.");
                EndOfGame();
            }
            else
            {
                Console.WriteLine("Wrong word!");
            }
        }

        //method to guess the correct letter from the word
        //will return nothing if same letter is repeated again
         void GuessLetter(char letter)
        {
            String letters = lettersUsed.ToString();
            if (letters.Contains(letter))
            {
                Console.WriteLine("You have already made that guess!");
            }
            else
            {
                lives--;
                lettersUsed.Append(letter); 
                if (IsInWord(letter))
                {
                    Console.WriteLine("Yay! The letter " + letter + " is in the word.");
                }
                else
                {
                    Console.WriteLine("Sorry, the letter " + letter + " is not in the word.");
                }
            }
            if (StringEqualsCharArray(secretWord, theWord))
            {
                Console.Write("Congratualtions! You have guessed all the right characters.\n" +
                    "The word is " + secretWord + ".\n");
                EndOfGame();
            }
        }

        //to check if that letter is present in word or not
        public bool IsInWord(char letter)
        {
            bool letterIsInWord = false;

            for (int i = 0; i < theWord.Length; i++)
            {
                if (secretWord[i].Equals(letter))
                {
                    theWord[i] = letter;
                    letterIsInWord = true;

                }
            }

            return letterIsInWord;
        }

        //to check if all the letters in word stored in array is equal to the given word
        public bool StringEqualsCharArray(String str, char[] chars)
        {
            if (str.Length == chars.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] != chars[i]) return false;
                }
                return true;
            }
            return false;
        }

        //method for ending the game if user wants to continues or not
        void EndOfGame()
        {
            Console.WriteLine("Would you like to play again? Y/N");
            String answer = Console.ReadLine() ?? string.Empty;
            String ans = answer.ToUpper();
            if (ans.Equals("N"))
            {
                Console.WriteLine("Goodbye, see you later!");
                keepAlive = false;
            }
            else if (ans.Equals("Y"))
            {

                Console.WriteLine("Go ahead!");
                InitGame();
            }
            else
            {
                Console.WriteLine("Please choose Y or N");
                EndOfGame();
            }

        }

    }

}
