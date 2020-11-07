using System;

namespace ConsoleApp1
{
    class Program
    {
      
        //https://leetcode.com
        //https://leetcode.com/problems/the-skyline-problem/description/
        static void Main(string[] args)
        {
            //2592000
            //2592000
            //var ts = TimeSpan.FromDays(30).TotalSeconds;
            //var s = ts.TotalSeconds;
            //var iaa = (int) 'A';

            //CodingAlgorithm.Other.A.Meth();
            //return;

            //CodingAlgorithm.Other.TestClass.RunCode();
            //return;

            var easy = 49;
            var medium = 36;
            var hard = 0;
            Console.WriteLine("Education completed: "+ (easy+hard+medium)*100/300 + "%");

            var t = DateTime.Now;                

          //  Easy.Class49.RunCode();
           Medium.Class37.RunCode();
            //Hard.Class01.RunCode();

            Console.WriteLine("********************");
            Console.WriteLine("Total time: " + ( DateTime.Now-t).TotalMilliseconds + " ms");

            Console.ReadLine();
        }


       //repeat: medium 14





    }
}
