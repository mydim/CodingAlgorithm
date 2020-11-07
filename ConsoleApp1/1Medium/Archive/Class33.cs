using CodingAlgorithm;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class33
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

            var a = "test";
            var b = common(a);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(b);

            Console.ReadLine();
        }

        public static List<int> RightSideView(TreeNode root)
        {
            var result = new List<int>();
            if (root == null) return result;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Any()) {
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    if (i == 0) result.Add(node.val);

                    if (node.right != null) queue.Enqueue(node.right);
                    if (node.left != null) queue.Enqueue(node.left);
                }
            }

            return result;
        }


        public static string common(string a)
        {
            return a;
        }
    }
}
