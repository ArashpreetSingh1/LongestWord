using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___5
{
    class Program
    {

        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine("the longest word is : ");
            Console.WriteLine(a.MyFunctionA("Ada Lovelace wrote the first alogrithm designed for processing by an Analytical Engine."));
        }
        public bool  MyFunctionA(string input)
        {
            //Write a C# program to find the longest word in a string.
            string[] words = input.Split(' ');
            int wordArrayLength = words.Length;
            int[] wordsLength = new int[wordArrayLength];
            int x = 0;
            foreach (var word in words)
            {
                //TODO
            }
            //loop post condition: we now have array wordsLength which
            // contains the lengths of each word

            string currentWord = words[0];
            string nextWord;
            string longestWord = currentWord;

            for (int y = 0;y<words.Length-1;y++)
            {
                currentWord = words[y];
                nextWord = words[y + 1];
                //TODO: Use an IFStatement to make sure that variable longestWord
                // is always set to the Longest Word in the input string
                
            }
            return input;
        }
        }
    }

