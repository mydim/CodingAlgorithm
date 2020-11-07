using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    // Coding scenario:
    // We are asked to implement a method that would copy data from a given array of characters called 
    // source
    // into the given output 
    // char array of a fixed size called 
    // output. 
    // We are also instructed to 
    // insert a CR (\r) char in front of every LF (\n) char we encounter in the source array. 
    // The source array may vary in size and can be as large as 2 GB. 
    // The output array will be given to us pre-initialized with the size
    // based on the client's needs. 
    // In case the size of source is larger than the size of output array the said
    // method will be called repeatedly multiple times 
    // until the last character is copied from source to output.
    //
    // Implementation details: see comments below

    //      abc
    //      def

    //      abc\ndef
    //      abc\r\ndef

    //      [=========================================================================] 2 GB
    //      [=] 1 MB



    public class ClassTest12
    {
        public static void FormatArray<T>(T[] arrIn, T[] arrOut, T el) where T : IComparable<T>
        {
            T buffer;

            //for cycle element for arrIn
            //for shift element for arrOut
            for (int i = 0, shift = 0; (i < arrIn.Length) && (shift < arrOut.Length); i++, shift++)
            {
                buffer = arrIn[i];
                
                if (buffer.CompareTo(el) == 0)
                {
                    arrOut[shift++] = el;

                    if (shift < arrOut.Length)
                        arrOut[shift] = buffer;
                    else
                        break;
                }
                else
                    arrOut[shift] = buffer;
            }

        }
    }

    public static class Class12
    {
        public static void FormatArray(char[] arrIn, char[] arrOut)
        {
            char charBuffer;

            //for cycle element for arrIn
            //for shift element for arrOut
            for (int i = 0, shift = 0; (i < arrIn.Length) && (shift < arrOut.Length); i++, shift++)
            {
                charBuffer = arrIn[i];
                if (charBuffer == '\n')
                {
                    arrOut[shift++] = '\r';                    

                    if (shift < arrOut.Length)
                        arrOut[shift] = charBuffer;
                    else
                        break;
                }
                else
                    arrOut[shift] = charBuffer;
            }

        }


        public static void RunCode()
        {
            var str1 = "abc\ndef";

            var arr1 = str1.ToCharArray();
            var arr2 = new char[6];


            CodingAlgorithm.CodeUtils.PrintArray(arr1, true);

            FormatArray(arr1, arr2);


            Console.WriteLine("Result:");

            CodingAlgorithm.CodeUtils.PrintArray(arr2, true);

        }





    }
}
