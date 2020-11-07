using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class30
    {
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

            //    var b = LetterCombinations("237");

            //  Console.WriteLine(string.Join(", ", b.ToArray()));
            var sb = ReverseWords("a good   example");
            //sb.Append
            Console.WriteLine(sb);
            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            var sb = new List<string>();

            var tempWord = "";

            for (int i = s.Length-1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (tempWord != "")
                    {
                        sb.Add(tempWord);
                        tempWord = "";
                    }                
                    continue;
                }

                tempWord = s[i] + tempWord;
            }

            if (tempWord != "")
            {
                sb.Add(tempWord);
            }


            return string.Join(" ", sb.ToArray());
        }
    }
}
