using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class10
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

            var b = LessTransforms(new[] { "hot", "dot", "dog", "lot", "log", "cog" }, "hit", "cog");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        //127
        public static int LessTransforms(string[] wordlist, string begin, string end)
        {
            var set= new HashSet<string>();
            foreach (var word in wordlist)
            {
                set.Add(word);
            }

            if (!set.Contains(end))
            {
                return 0;
            }
            
            var q = new Queue<string>();
            q.Enqueue(begin);
            var level = 1;

            while (q.Count != 0)
            {
                var size = q.Count;
                for (int i = 0; i < size; i++)
                {
                    var wordChars = q.Peek().ToArray();
                    for (int j = 0; j < wordChars.Length; j++)
                    {
                        var originChar = wordChars[j];
                        for (char c = 'a'; c <= 'z'; c++)
                        {
                            if (originChar == c) continue;

                            wordChars[j] = c;
                            var newWord = new string(wordChars);
                            if (newWord == end) return level + 1;

                            if (set.Contains(newWord))
                            {
                                set.Remove(newWord);
                                q.Enqueue(newWord);
                            }
                        }

                         wordChars[j] = originChar;
                    }
                }

                level++;
            }

            return 0;
        }

    }
}
