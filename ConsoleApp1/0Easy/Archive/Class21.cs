using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class21
    {
    //    804. Unique Morse Code Words
    //Easy
    //390
    //283
    //Favorite
    //Share
    //International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes,
    //as follows: "a" maps to ".-", "b" maps to "-...", "c" maps to "-.-.", and so on.
    //For convenience, the full table for the 26 letters of the English alphabet is given below:
    //[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    //Now, given a list of words, each word can be written as a concatenation of the Morse code of each letter.For example,
    //"cba" can be written as "-.-..--...", (which is the concatenation "-.-." + "-..." + ".-").
    //We'll call such a concatenation, the transformation of a word.
    //Return the number of different transformations among all words we have.
    //Example:
    //Input: words = ["gin", "zen", "gig", "msg"]
    //Output: 2
    //Explanation: 
    //The transformation of each word is:
    //"gin" -> "--...-."
    //"zen" -> "--...-."
    //"gig" -> "--...--."
    //"msg" -> "--...--."

    //There are 2 different transformations, "--...-." and "--...--.".
    //Note:

    //The length of words will be at most 100.
    //Each words[i] will have length in range[1, 12].
    //words[i] will only consist of lowercase letters.

        public static void RunCode()
        {
            //_arrayData = new List<KeyValuePair<int, int>>();
            //var arr1 = new int[0];
            //var arr2 = new int[] { };
            //int[] arr3 = { };
            //var arr4 = Enumerable.Empty<int>().ToArray();
            //var arr5 = Array.Empty<int>();
            //var arr6 = new List<int>().ToArray();
            //int count=0;
            //Math.Max
            //Math.Min
            //(bln ? 1 : 0)
            //int.Parse(res);


            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}

            var i = UniqueMorseRepresentations(new []{"gin", "zen", "gig", "msg"});

            //Console.WriteLine(b);
        Console.ReadLine();
        }

        public static int UniqueMorseRepresentations(string[] words)
        {

            var h = new HashSet<string>();
            foreach (var word in words)
            {
                h.Add(Morze(word));
            }
            return h.Count;
        }

        static string[] MorArr = new string[] {
            ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."
        };

        private static string Morze(string word)
        {
            var sb = new StringBuilder();

            
            for (int i = 0; i < word.Length; i++)
            {
                var ci = (int)(word[i]);
                if ((ci >= 65) && (ci < 90))
                {
                    ci += 32;
                }

                sb.Append(MorArr[ci - 97]);
            }

            return sb.ToString();
        }
    }
}
