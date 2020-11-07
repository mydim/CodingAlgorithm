using CodingAlgorithm;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class12
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

            var root = new TreeNode(9);
            root.left = new TreeNode(1);
            root.right = new TreeNode(2);

            root.left.left = new TreeNode(4);
            root.left.left.left = new TreeNode(8);
            root.left.right = new TreeNode(5);

            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            var json = JsonConvert.SerializeObject(root, Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine("---------------");

            var clone = CloneNode(root);

            var json2 = JsonConvert.SerializeObject(clone, Formatting.Indented);
            Console.WriteLine(json2);

            //    var b = LetterCombinations("237");

            //  Console.WriteLine(string.Join(", ", b.ToArray()));

            Console.ReadLine();
        }

        private static TreeNode CloneNode(TreeNode node)
        {
            if (node == null) return null;

            var newNode = new TreeNode(node.val);

            newNode.right = CloneNode(node.left);
            newNode.left= CloneNode(node.right);

            return newNode;
        }

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            return new TreeNode(0);
        }
    }
}

