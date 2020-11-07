using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class04
    {
        static Dictionary<char, int> _dictRoman;
        static Dictionary<char, int> dictRoman
        {
            get
            {
                if (_dictRoman == null)
                {
                    _dictRoman = new Dictionary<char, int>();
                    _dictRoman.Add('I', 1);
                    _dictRoman.Add('V', 5);
                    _dictRoman.Add('X', 10);
                    _dictRoman.Add('L', 50);
                    _dictRoman.Add('C', 100);
                    _dictRoman.Add('D', 500);
                    _dictRoman.Add('M', 1000);
                }

                return _dictRoman;
            }

        }



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

            
            Console.WriteLine(RomanToInt("XIV"));
            //Console.ReadLine();

            //return ;
        }



        public static  int RomanToInt(string s)
        {


            //I can be placed before V (5) and X (10) to make 4 and 9. 
            //X can be placed before L (50) and C (100) to make 40 and 90. 
            //C can be placed before D (500) and M (1000) to make 400 and 900.        

            int val = 0;
            var res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                i = GetNextRomanNumber(s, i, ref res);
                val += res;
            }

            return val;
        }



        public static int GetNextRomanNumber(string s, int i, ref int res)
        {
            var nextChar = Char.MinValue;

            if (i + 1 <= s.Length - 1)
            {
                nextChar = s[i + 1];

                var decr = 0;
                if ((s[i] == 'I') && ((nextChar == 'V') || (nextChar == 'X')))
                    res = dictRoman[nextChar] - 1;

                else
                if ((s[i] == 'X') && ((nextChar == 'L') || (nextChar == 'C')))
                    res = dictRoman[nextChar] - 10;

                else if ((s[i] == 'C') && ((nextChar == 'D') || (nextChar == 'M')))
                    res = dictRoman[nextChar] - 100;

                if (decr != 0)
                    i++;
                else
                    res = dictRoman[s[i]];

                return i;


            }

            res = dictRoman[s[i]];

            return i;
        }
    }
}
