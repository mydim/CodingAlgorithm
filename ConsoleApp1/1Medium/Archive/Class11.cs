using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class11
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

            Console.ReadLine();
        }

        public static List<string> LetterCombinations(string digits)
        {
            if (digits.Length == 0) return new List<string>();
            var res = new Queue<string>();

            var mapping = new[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            for (int i = 0; i < digits.Length; i++)
            {
                var idx = (int)Char.GetNumericValue(digits[i]);
                var mc = mapping[idx].ToArray();

                while (res.Count == 0 || res.Peek().Length == i)
                {
                    var per = res.Count != 0 ? res.Dequeue() : "";
                    foreach (var c in mc)
                    {
                        res.Enqueue(per + c);
                    }
                }
            }

            return res.ToList();
        }


        public static List<string> LetterCombinations2(string digits)
        {
            if (digits.Length == 0) return new List<string>();
            var res = new Queue<string>();

            var mapping = new[] { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            for (int i = 0; i < digits.Length; i++)
            {
                var idx = (int)Char.GetNumericValue(digits[i]);
                var mc = mapping[idx].ToArray();
            }

            return new List<string>();
        }

        public static void AddCharToQueue(char[] chars, Queue<string> res, int curLength)
        {
            while (res.Count == 0 || res.Peek().Length == curLength)
            {
                var per = res.Count != 0 ? res.Dequeue() : "";
                

            }
        }
    }
}
