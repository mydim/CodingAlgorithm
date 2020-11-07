using CodingAlgorithm;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class36
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

            var root = new BinaryNode(0); // 1
            root.children.Add(new BinaryNode(1));
            root.children.Add(new BinaryNode(2)); // 2
            root.children.Add(new BinaryNode(3));

            root.children[1].children.Add(new BinaryNode(4));
            root.children[1].children.Add(new BinaryNode(5));
            root.children[1].children[1].children.Add(new BinaryNode(6));// 3
            root.children[1].children[1].children[0].children.Add(new BinaryNode(7));// 4


            //var a = "test";
            var b = common(root);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static int common(BinaryNode root)
        {
            return helper(root, 0);
        }

        private static int helper(BinaryNode root, int v)
        {
            if (root.children.Count == 0)
                return 0;

            var maxLevel = v + 1;
            foreach (var c in root.children)
            {
                var depth = helper(c, v + 1);
                if (depth > maxLevel)
                {
                    maxLevel = depth;
                }
            }

            return maxLevel;
        }
    }
}
