using System;
using System.Collections.Generic;
namespace ConsoleApp8
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] wordArray = new string[3] { "sweden", "denmark", "finland" };
            Random random = new Random();
            int index = random.Next(wordArray.Length);
            string secretWord = wordArray[index];
           
            
            int WrongNumber = 0;
            List<char> listguessedLetter = new List<char>();
            int rightNumber = 0;

            while (rightNumber != secretWord.Length && WrongNumber != 10  )
            {
                Console.Write("\r\n");
                Console.Write("letters guessed so far: ");
                foreach (char letter in listguessedLetter)
                {
                   
                    Console.Write(letter + " ");
                } 
                Console.Write("\nGuess a letter: ");
                char letterGuessed =Convert .ToChar ( Console.ReadLine());
                if (listguessedLetter.Contains(letterGuessed))
                {
                    Console.Write(" You have already guessed this letter");

                }
                else
                {
                    bool resultbool = false;
                    for (int i = 0; i < secretWord.Length; i++)
                    {
                        if (letterGuessed == secretWord[i])
                        { resultbool = true; }
                    }

                    if (resultbool)
                    {
                        listguessedLetter.Add(letterGuessed);
                        rightNumber += 1;

                        Console.Write("\r\n");
                        foreach (char letter in secretWord )
                        {
                            if (listguessedLetter .Contains (letter ))
                            {
                                Console.Write($"{letter} ");
                            }
                            else
                            {
                                Console.Write(" " );
                            }
                        }
                       
                    }
                    else
                    {
                        WrongNumber += 1;
                        listguessedLetter.Add(letterGuessed);
                        Console.WriteLine($" You have {10-WrongNumber } chanses to guess.");
                       
                      
                    }
                }
            }
            Console.WriteLine(" You are game over!");
        }
    }
}
