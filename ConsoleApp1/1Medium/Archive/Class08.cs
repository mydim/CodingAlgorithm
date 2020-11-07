using CodingAlgorithm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class08
    {

        //subscription (4?)
        //billing



        //DB
        //WebApi
        //UI-Call
        //UI

        public static double GetArr(int[] arr1, int[] arr2)
        {
            if (arr1 == null || arr1.Length == 0)
            {
                throw new Exception("");
            }

            if (arr1.Length != arr2.Length)
            {
                throw new Exception("");
            }



            var n = 0;

            var v1 = 0;
            var v2 = 0;

            var arrIndex1 = 0;
            var arrIndex2 = 0;

            while (n < arr1.Length + 1)
            {
                if (arrIndex1 == arr1.Length)
                    arrIndex2++;

                if (arrIndex2 == arr1.Length)
                    arrIndex1++;

                int val;
                if (arr1[arrIndex1] < arr2[arrIndex2])
                {
                    val = arr1[arrIndex1];
                    arrIndex1++;
                }
                else
                {
                    val = arr2[arrIndex2];
                    arrIndex2++;
                }

                if (n == arr1.Length - 1)
                {
                    v1 = val;
                }
                else
                if (n == arr1.Length)
                {
                    v2 = val;
                }

                n++;
            }
            //5
            //4 (n
            //5 (n+1)

            // MergeSort

            return (double)(v1+v2)/2;
        }

        public static void RunCode()
        {
            var arr1 = new int[] { 1, 3, 4, 5, 7 };
            var arr2 = new int[] { 2, 3, 6, 8, 9 };

            var res = GetArr(arr1, arr2);



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

            var chars1 = new int[26];
            var chars2 = new int[26];

            //for (int i = 0; i < length; i++)
            //{

            //}

            //foreach (var item in collection)
            //{

            //}
            //var v = new HashSet<int>();
            //v.Remove()

            // var b = countingValleys(1, "UDDDUDUU");

            //var b = jumpingOnClouds(new int[] { 0 ,0, 1, 0 ,0, 1, 0 });

            //var b = repeatedString("aba", 10);
            // var b = alternatingCharacters("AAABBB");

            //var d = 54;
            //var arrInput = new int[] { 1,2,3,4,5 };
            //var arr = rotLeft(arrInput, d);
            //CodeUtils.PrintArrayLine(arr);

            //int[][] two = new int[6][];
            //two[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            //two[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            //two[2] = new int[6] { 1, 1, 1, 0, 0, 0 };

            //two[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            //two[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            //two[5] = new int[6] { 0, 0, 1, 2, 4, 0 };

            //var b = hourglassSum(two);

            //var prices = new int[] {3,7,2,9,4 };
            //var k = 15;
            //var b = maximumToys(prices, k);

            //  var b = "1";
            //   checkMagazine(new[] { "test", "test", "test1" }, new[] { "test", "test" });

            //int[][] queries = new int[3][];
            //queries[0] = new int[] { 1, 3, 100 };
            //queries[1] = new int[] { 2, 5, 100 };
            //queries[2] = new int[] { 3, 4, 100 };
            //var b = arrayManipulation(3, queries);

            var p = "aabbcd";
            //var k = 15;
            var b = "";
          //  var b = func(p);

            Console.WriteLine(b);
            Console.ReadLine();
        }

        //private static object func(object p)
        //{
        //   // throw new NotImplementedException();
        //}

        static string isValid(string s)
        {

            var dict = new int[255];

            for (int i = 0; i < s.Length; i++)
            {
                dict[s[i]]++;
            }

            var isOnMistakeExist = false;
            for (int i = 0; i <255 ; i++)
            {
                var c = dict[i];
                if (i < 'a' || i > 'z')
                    continue;

                if (c % 2 == 1)
                {
                    if (isOnMistakeExist)
                    {
                        return "NO";
                    }
                    isOnMistakeExist = true;
                }
            }

            return "YES";
        }


        static long arrayManipulation(int n, int[][] queries)
        {
            var max = 0;
            var arr = new int[n];
            foreach (var q in queries)
            {
                var val = q[2];
                for (int i = q[0]; i <= q[1]; i++)
                {
                    if (i >= n)
                        break;

                    arr[i] += val;
                    if (arr[i] > max)
                        max = arr[i];
                }
            }

            return max;
        }


        public class   SinglyLinkedListNode {
            public  int data;
            public  SinglyLinkedListNode next;
      }

    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {

            var hash1 = new HashSet<SinglyLinkedListNode>();
            for (; head1 != null; head1 = head1.next)
            {
                if (hash1.Contains(head1))
                {
                    break;
                }

                hash1.Add(head1);
            }

            var hash2 = new HashSet<SinglyLinkedListNode>();
            for (; head2 != null; head2 = head2.next)
            {
                if (hash2.Contains(head2))
                {
                    break;
                }

                hash2.Add(head2);
            }

            foreach (var h in hash1)
            {
                if (hash2.Contains(h))
                {
                    return h.data;
                }
            }

            return -1;

            /*
                    while (head1 != null)
                    {
                        if (head1.data == head2.data)
                        {
                            return head1.data;
                        }

                        while(head2 != null && head2.data < head1.data)
                        {
                            head2 = head2.next;
                        }

                        if (head2 == null)
                        {
                            return -1;
                        }

                        if (head2.data == head1.data)
                        {
                            return head1.data;
                        }

                        head1 = head1.next;
                    }

                    return -1;
                    */
        }


        static string twoStrings(string s1, string s2)
        {
            Console.WriteLine(s1);
            Console.WriteLine("---");
            Console.WriteLine(s2);
            return "TEST";
        }

        static void checkMagazine(string[] magazine, string[] note)
        {
            var wordDict = new Dictionary<string, int>();
            foreach (var a in magazine)
            {
                if (wordDict.ContainsKey(a))
                {
                    wordDict[a]++;
                }
                else
                    wordDict.Add(a, 1);
            }

            foreach (var a in note)
            {
                if (!wordDict.ContainsKey(a))
                {
                    Console.WriteLine("No");
                    return;
                }

                if (wordDict[a] == 1)
                {
                    wordDict.Remove(a);
                }
                else
                {
                    wordDict[a]--;
                }
            }

            Console.WriteLine("Yes");

        }


        static int maximumToys(int[] prices, int k)
        {

            Array.Sort(prices);

            var checkSum = 0;
            var i = 0;

            while (true)
            {
                if (i == prices.Length)
                {
                    break;
                }

                var val = prices[i];
                if (checkSum + val >= k)
                {
                    break;
                }

                checkSum += val;

                i++;
            }
            
            return i;
        }

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr)
        {

            var maxSum = 0;
            for (int x = 0; x < arr.Length; x++)
            {

                for (int y = 0; y < arr.Length; y++)
                {
                    var sum = GetHourGlassSum(arr, x, y);
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        public static int GetHourGlassSum(int[][] arr, int x, int y)
        {
            if (x + 2 >= arr.Length )
            {
                return -1;
            }

            if (y + 2 >= arr.Length )
            {
                return -1;
            }

            return arr[y][x] + arr[y][x + 1] + arr[y][x + 2] +
                                    arr[y + 1][x + 1] +
                          arr[y + 2][x] + arr[y + 2][x + 1] + arr[y + 2][x + 2];
        }


        static int[] rotLeft(int[] a, int d)
        {

            var b = new int[a.Length];

            var startIndex = a.Length - d % a.Length;

            var index = 0;
            foreach (var v in a)
            {
                b[startIndex] = a[index];

                index++;
                startIndex++;
                if (startIndex >= b.Length)
                {
                    startIndex = 0;
                }
            }
            return b;

            //12345 12345

            //5 - 2
            //3, begin at 4

            //5 - 1
            //4, begin at 5
        }


        static int alternatingCharacters(string s)
        {
            //12
            if (s.Length == 0) return 0;
            if (s.Length == 1) return 0;

            var curChar = s[0];
            var res = 0;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == curChar)
                {
                    Console.WriteLine(i);
                    res++;
                }
                else
                {
                    curChar = s[i];
                }
            }

            return res;
        }

        // Complete the repeatedString function below.
        static long repeatedString(string s, int n)
        {


            if (s.Length >= n)
            {
                return FindCountAInString(s);
            }

            var cnt = FindCountAInString(s);

            var resStr = s.Substring(0, n % s.Length);
            var res = n / s.Length * cnt + FindCountAInString(resStr);

            return res;
        }

        public static int FindCountAInString(string s)
        {
            var cnt = 0;
            foreach (var c in s)
                if (c == 'a') cnt++;

            return cnt;
        }


        static int jumpingOnClouds(int[] c)
        {

            var countJumps = 0;
            var index = 0;
            while (index != c.Length)
            {
                if (TryJump(c, index, 2))
                {
                    index = index + 2;
                }
                else
                {
                    index++;
                }

                if (index < c.Length)
                {
                    countJumps++;
                }
            }

            return countJumps;
        }

        public static bool TryJump(int[] c, int index, int jump)
        {
            if (index + jump >= c.Length)
            {
                return false;
            }

            return c[index + jump] == 0;
        }


        static int countingValleys(int n, string s)
        {

            var countV = 0;
            var alt = 0;
            var isNewAltNeedToCount = true;

            foreach (var c in s)
            {
                if (c == 'D')
                {
                    alt--;
                }
                else
                {
                    alt++;
                }

                if (alt == -1 && isNewAltNeedToCount)
                {
                    countV++;
                    isNewAltNeedToCount = false;
                }
                else
                if (alt == 0)
                {
                    isNewAltNeedToCount = true;
                }
            }

            return countV;

        }

        public static TreeNode PruneTree(TreeNode root)
        {
            if (root == null) return null;

            root.left = PruneTree(root.left);
            root.right = PruneTree(root.right);

            if (root.val == 0 && root.left == null && root.right == null) root = null;

            return root;
        }
        
        public static bool IsNodeLastOn(TreeNode node)
        {
            return
               node.val == 1 &&
                node.left == null && node.right == null;
        }
    }

   


    public static class BTreePrinter
    {
        class NodeInfo
        {
            public TreeNode Node;
            public string Text;
            public int StartPos;
            public int Size { get { return Text.Length; } }
            public int EndPos { get { return StartPos + Size; } set { StartPos = value - Size; } }
            public NodeInfo Parent, Left, Right;
        }

        public static void Print(this TreeNode root, string textFormat = "0", int spacing = 1, int topMargin = 2, int leftMargin = 2)
        {
            if (root == null) return;
            int rootTop = Console.CursorTop + topMargin;
            var last = new List<NodeInfo>();
            var next = root;
            for (int level = 0; next != null; level++)
            {
                var item = new NodeInfo { Node = next, Text = next.val.ToString(textFormat) };
                if (level < last.Count)
                {
                    item.StartPos = last[level].EndPos + spacing;
                    last[level] = item;
                }
                else
                {
                    item.StartPos = leftMargin;
                    last.Add(item);
                }
                if (level > 0)
                {
                    item.Parent = last[level - 1];
                    if (next == item.Parent.Node.left)
                    {
                        item.Parent.Left = item;
                        item.EndPos = Math.Max(item.EndPos, item.Parent.StartPos - 1);
                    }
                    else
                    {
                        item.Parent.Right = item;
                        item.StartPos = Math.Max(item.StartPos, item.Parent.EndPos + 1);
                    }
                }
                next = next.left ?? next.right;
                for (; next == null; item = item.Parent)
                {
                    int top = rootTop + 2 * level;
                    Print(item.Text, top, item.StartPos);
                    if (item.Left != null)
                    {
                        Print("/", top + 1, item.Left.EndPos);
                        Print("_", top, item.Left.EndPos + 1, item.StartPos);
                    }
                    if (item.Right != null)
                    {
                        Print("_", top, item.EndPos, item.Right.StartPos - 1);
                        Print("\\", top + 1, item.Right.StartPos - 1);
                    }
                    if (--level < 0) break;
                    if (item == item.Parent.Left)
                    {
                        item.Parent.StartPos = item.EndPos + 1;
                        next = item.Parent.Node.right;
                    }
                    else
                    {
                        if (item.Parent.Left == null)
                            item.Parent.EndPos = item.StartPos - 1;
                        else
                            item.Parent.StartPos += (item.StartPos - 1 - item.Parent.EndPos) / 2;
                    }
                }
            }
            Console.SetCursorPosition(0, rootTop + 2 * last.Count - 1);
        }

        private static void Print(string s, int top, int left, int right = -1)
        {
            Console.SetCursorPosition(left, top);
            if (right < 0) right = left + s.Length;
            while (Console.CursorLeft < right) Console.Write(s);
        }
    }
}
