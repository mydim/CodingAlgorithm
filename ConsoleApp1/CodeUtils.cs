using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingAlgorithm
{
    public static class CodeUtils
    {
        public static void PrintMatrix(int[,] rawNodes, bool line = false, string format = "{0} ")
        {
            int rowLength = rawNodes.GetLength(0);
            int colLength = rawNodes.GetLength(1);
            string arrayString = "";
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    arrayString += string.Format(format, rawNodes[i, j]);
                }
                arrayString += System.Environment.NewLine + System.Environment.NewLine;
            }

            Console.WriteLine(arrayString);
        }
    

        public static void PrintArray(int[] a, bool line = false, string format= "{0}")
        {
            var s = "";
            foreach (var i in a)
            {
                s = s + ", '" + i.ToString() + "'";
            }

            s = s + " /Length:" + a.Length;
            if (line)
                Console.WriteLine(string.Format(format, s));
            else
                Console.Write(string.Format(format, s));
        }


        public static void PrintArray(double[] a, bool line = false, string format = "{0}")
        {
            var s = "";
            foreach (var i in a)
            {
                s = s + ", '" + i.ToString() + "'";
            }

            s = s + " /Length:" + a.Length;
            if (line)
                Console.WriteLine(string.Format(format, s));
            else
                Console.Write(string.Format(format, s));
        }

        public static void PrintArray(char[] a, bool line = false, string format = "{0}")
        {
            var s = "";
            foreach (var i in a)
            {
                s = s + (s.Length>0? ", '":"'") + i.ToString() + "'";
            }

            s = s + " /Length:" + a.Length;
            if (line)
                Console.WriteLine(string.Format(format, s));
            else
                Console.Write(string.Format(format, s));
        }

        internal static void PrintArrayLine(int[] a, string format = "{0}")
        {
            PrintArray(a, true, format);
        }
    }
}
