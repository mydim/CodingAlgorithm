using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class25
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

            var b = find(25);
            Console.WriteLine(b);
            Console.ReadLine();
        }


        public static int find(int processNumber)
        {
            Queue<int> previousLevel;
            var currentLevel = new Queue<int>();            
            currentLevel.Enqueue(1);

            for (int i = 2; i <= processNumber; i++)
            {
                previousLevel = currentLevel;
                currentLevel = new Queue<int>();

                while (previousLevel.Count>0)
                {
                    var levelNumber = previousLevel.Dequeue();
                   
                    for (int j = 1; j <= levelNumber; j++)
                    {
                        currentLevel.Enqueue(i);

                        if (i == processNumber)
                        {
                            return levelNumber;
                        }
                        i++;
                    }
                    i--;
                }                
            }

            return currentLevel.Dequeue();
        }

    }
}
