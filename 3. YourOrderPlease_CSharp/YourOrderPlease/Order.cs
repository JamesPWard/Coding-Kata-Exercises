/*
* Your task is to sort a given string. Each word in the string will contain 
* a single number. This number is the position the word should have in the 
* result.
* 
* Note: Numbers can be from 1 to 9. So 1 will be the first word (not 0).
* 
* If the input string is empty, return an empty string. The words in the 
* input String will only contain valid consecutive numbers.
*
* From https://www.codewars.com/
*/

using System;
using System.Text.RegularExpressions;

namespace YourOrderPlease
{
    public class Order
    {
        public static string DoOrder(String words)
        {
            string solution = "";

            //Check if string is empty
            if (words.Length > 0)
            {
             
                //Init arrays and split input string
                var wordArr = words.Split(' ');
                var newOrder = new string[wordArr.Length];
            
                //Find number in word and reposition in new array
                foreach (var word in wordArr)
                {
                    var numInWord = Convert.ToInt16(Regex.Match(word, @"\d+").Value);
                    newOrder[numInWord-1] = word;
                }

                //Rebuild newly ordered string
                foreach (var word in newOrder)
                {
                    solution += (word + ' ');
                }

                solution = solution.TrimEnd();

            }

            return solution;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DoOrder("is2 Thi1s T4est 3a"));
        }
    }
}
