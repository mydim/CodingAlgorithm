using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class19
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

            //    var b = LetterCombinations("237");

            // 

            var root = new TreeNode(1);
            root.left = new TreeNode(3);
            root.right = new TreeNode(2);

            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(6);
            root.left.right.right = new TreeNode(5);

            var tr = LowestCommonAncestor(root, root.right, root.left.right.right);
            
            Console.WriteLine(tr.val);

            Console.ReadLine();
        }

        public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var b1 = Find(root, p, new HashSet<TreeNode>());
            var b2 = Find(root, q, new HashSet<TreeNode>());
            
            foreach (var item in b1)
            {
                if (b2.Contains(item))
                    return item;
            }

            return null;
        }

        private static HashSet<TreeNode> Find(TreeNode node, TreeNode p, HashSet<TreeNode> common)
        {
            if (node == null)
            {
                return null;
            }

            if (node.val == p.val)
            {
                return common;
            }

            var resRight = Find(node.right, p, common);
            if (resRight != null)
            {
                common.Add(node);
                return resRight;
            }

            var resLeft = Find(node.left, p, common);
            if (resLeft != null)
            {
                common.Add(node);
                return resLeft;
            }

            return null;
        }
    }
}
