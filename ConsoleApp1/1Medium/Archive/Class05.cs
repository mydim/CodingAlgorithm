using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class05
    {

        public static void RunCode()
        {

            //Order of the Matrix : 2  2
            //Matrix Elements :
            //1 2
            //3 4
            //Write a C# gram to get the transpose of this matrix
            //Transpose means you rotate the matrix by 90 degree


       ///     Array.

            var arr = new int[2, 2] ;
            arr[0, 0] = 1;
            arr[1, 0] = 2;
            arr[0, 1] = 3;
            arr[1, 1] = 4;

            //3 1
            //4 2

            var arr2 = new int[2, 2];
            for (int y = 0; y < arr.Length; y++) 
            {
                for (int x = 0; x < arr.Length; x++)
                {   
                    //00  - > X+1, Y
                        //*8
                        //00
                    //10  - > X, Y+1
                        //0*
                        //08
                    //01 -> X, Y-1
                        //80
                        //*0
                    //11 -> X-1, Y
                        //00
                        //8*

                    //arr2[x, y] =

                   }

                //0 0 -> 1 0 -
                //1 0 -> 1 1 -
                //1 1 -> 0 1 -
                //0 1 -> 0 0 -
                
            }




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



            //foreach (var item in collection)
            //{

            //}
            //Console.Write("");
            //Console.ReadLine();

            //return ;
        }


    }
}
