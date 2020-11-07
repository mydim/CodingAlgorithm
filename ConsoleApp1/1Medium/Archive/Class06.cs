using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class06
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

            Convert("PAYPALISHIRING", 4);

            Console.Write("");
            Console.ReadLine();

            return;


        }

        public static string Convert(string s, int numRows)
        {
            if (numRows < 0)
                return "";

            if (numRows == 1)
                return s;

            var isFullLine = true;
          
            var arr = new char[s.Length, numRows];

            var col = 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (isFullLine)
                {
                    for (int r = 0; r < numRows; r++)
                    {
                        if (i == s.Length)
                            break;

                        arr[col, r] = s[i];
                        i++;
                    }
                }
                else
                {
                    var sigPos = numRows - 2;
                    for (int r = sigPos; r > 0 ; r--)
                    {
                        if (i == s.Length)
                            break;

                        arr[col, sigPos] = s[i];
                        sigPos--;
                        i++;
                        col++;
                    }
                    col--;
                }

                i--;
                isFullLine = !isFullLine;
                col++;
            }

            var res = "";
            for (var row = 0; row < numRows; row++)
            {
                for (var c = 0; c < s.Length; c++)
                {
                    var cr = arr[c, row];
                    if (cr != Char.MinValue)
                    {
                        res = res + cr;
                    }
                }
            }

            Console.WriteLine(res);

            return res;

        }
    }
}
