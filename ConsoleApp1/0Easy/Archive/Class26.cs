using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class26
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

            var root = new BinaryNode(1); //1

            var child1 = new BinaryNode(2);
            var child2  = new BinaryNode(3);//2
            var child3 = new BinaryNode(4);
            root.childs = new BinaryNode[] { child1, child2, child3 };


            var child6 = new BinaryNode(6);
            var child7 = new BinaryNode(7);            
            child1.childs = new BinaryNode[] { child6, child7 };

            var child8 = new BinaryNode(8);
            var child9 = new BinaryNode(9);
            child2.childs = new BinaryNode[] { child8, child9 };

            var child10 = new BinaryNode(10);
            child6.childs = new BinaryNode[] { child10 };

            //var child11 = new BinaryNode(11);
            //child10.children = new BinaryNode[] { child11 };

            var b = MaxDepthOfTree(root);
            Console.WriteLine(b);
            Console.ReadLine();
        }

        private static int MaxDepthOfTree(BinaryNode root)
        {
            if (root == null) return 0;

            int depth = 0;

            var q = new Queue<BinaryNode>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                var size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    var curBinaryNode = q.Dequeue();

                    if (curBinaryNode.children == null) continue;

                    foreach (var child in curBinaryNode.children)
                    {
                        q.Enqueue(child);
                    }
                }

                depth++;
            }

            return depth;
        }
    }
}
