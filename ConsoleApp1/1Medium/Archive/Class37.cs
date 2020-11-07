using CodingAlgorithm;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class37
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

            //var a = "abcdefghij";
            //var b = "cdgi";
            ////var c= common(a,b);

            //var k = "00000-42a1234";
            //var d = MyAtoi(k);

            var s1 = "1+20/4";
            var ans = Calc(s1);
            //var nums = new int[] { -1, 0, 1, 2, -1, -4 };
            //var list = ThreeSum(nums);

            //var arr2 = new int[] { 0, 0, 0, 0, 1, 1, 1, 1 };
            //var i= Array.BinarySearch(arr2, 1);

            //var arr = new int[] { 1, 2, 3, 4 };
            //var arr = new int[] { 5, 5, 10, 40, 50, 35 };

            //var s = FindMaxSum(arr);

            //            var arr = new int[] { 1, 10, 3, 40, 18 };
            // var s = smallestSubWithSum(arr, 50);

            var s = "ADOBECODEBANC";
            var t = "ABC";

             s = MinWindow(s, t);
            //            var a = SubarraySum(arr, 7);
            // var arr1 = ProductExceptSelf(arr);

            //    var b = common("I was here", "I have been here");

            Console.WriteLine(s);

            Console.ReadLine();
        }

        private static int Calc(string s1)
        {
            //// "/0 0"
            ///
            var ans = 0;
            var oper = '+';
            var tail = 0;

            for (int i = 0; i < s1.Length; i++)
            {
                var c = s1[i];
                if (c == ' ') continue;

                if (char.IsDigit(c))
                {
                    var number = "";
                    while (i < s1.Length && char.IsDigit(s1[i]))
                    {
                        c = s1[i];
                        number += c;
                        i++;
                    }

                    if (i != s1.Length) i--;

                    var num = int.Parse(number);

                    switch (oper)
                    {
                        case '+':
                            ans += tail;

                            tail = num;
                            break;

                        case '-':
                            ans += tail;

                            tail = -num;
                            break;

                        case '*':
                            tail *= num;
                            break;

                        case '/':
                            tail /= num;
                            break;
                    }

                    //+0 0
                    oper = char.MinValue;
                }
                else {
                    oper = c;
                }
            }

            return ans + tail;
        }

        public static string MinWindow(string source, string pattern)
        {
            var pHash = new Dictionary<char, int>();
            var sHash = new Dictionary<char, int>();

            var needToMatch = 0;
            foreach (var c in pattern)
            {
                needToMatch++;

                if (sHash.ContainsKey(c))
                {
                    pHash[c]++;
                }
                else
                {
                    sHash.Add(c, 0);
                    pHash.Add(c, 1);
                }
            }

            var n = source.Length;
            var l = 0;
            var r = 0;


            var minWindow = "";
            var matched = 0;

            // "ADOBECODEBANC", t = "ABC"

            while (r < n)
            {
                var rchar = source[r];
                if (sHash.ContainsKey(rchar))
                {
                    sHash[rchar]++;

                    if (sHash[rchar] <= pHash[rchar])
                    {
                        matched++;
                    }
                }


                while (matched == needToMatch)
                {
                    var len = 1 + r - l;
                    if (len < minWindow.Length || minWindow.Length == 0)
                    {
                        minWindow = source.Substring(l, len);
                    }

                    var lchar = source[l];
                    if (sHash.ContainsKey(lchar))
                    {
                        sHash[lchar]--;

                        if (sHash[lchar] < pHash[lchar])
                        {
                            matched--;
                        }
                    }

                    l++;
                }

                r++;
            }

            return minWindow;
        }

        // Returns length of smallest  
        // subarray with sum greater  
        // than x. If there is no  
        // subarray with given sum,  
        // then returns n+1 
        static int smallestSubWithSum(int[] arr, int x)
        {
            var minLength = int.MaxValue;

            //-100, 58, -53, 40, 18

            var l = 0;
            var r = 1;

            var sum = arr[0];
            if (sum > x)
            {
                return 1;
            }

            sum += arr[1];

            while (r < arr.Length) {
                if (sum > x)
                {
                    minLength = Math.Min(minLength, 1 + r - l);
                    if (minLength == 1)
                    {
                        return 1;
                    }

                    sum -= arr[l];
                    l++;
                }
                else {
                    r++;
                    if (r < arr.Length) {
                        sum += arr[r];
                    }
                }

            }

            return minLength;
        }

        static int FindMaxSum(int[] arr)
        {
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i%2] += arr[i];                
            }
            return Math.Max(arr[0], arr[1]);
        }


            public static int[] ProductExceptSelf(int[] nums)
        {
            var output = new int[nums.Length];


            ///1    2     3     4    
            ///1    1     2     6
            ///24   12    4      1
            
            
            ///24   12    8      6   


            output[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                output[i] = output[i - 1] * nums[i - 1];
            }

            var tmp = 1;
            for (int i = nums.Length - 2; i >=0 ; i--)
            {                
                //2 * 4
               // * 
                var newVal = nums[i+1] * tmp * output[i];
                output[i] = newVal;
                tmp = nums[i + 1] * tmp;
            }


            return output;
        }

        public static int SubarraySum(int[] nums, int k)
        {
            var mem = new Dictionary<int,int>();
            var cnt = 0;

            var curSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                curSum += nums[i];

                if (curSum == k)
                {
                    cnt++;
                }
                else
                if (mem.ContainsKey(curSum - k))
                {
                    cnt += mem[curSum - k];
                }

                if (mem.ContainsKey(curSum))
                {                    
                    mem[curSum]+=1;
                }
                else
                {
                    mem.Add(curSum, 1);
                }
            }

            return cnt;
        }

            public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums.Length < 3) return list;
            
            Array.Sort(nums);

            var left = 0;
            var right = nums.Length-1;

            var cur = left + 1;
            while (left < right) {
                var sum = nums[left] + nums[right] + nums[cur];
                if (sum==0) {
                    list.Add(new List<int>() { nums[left], nums[right], nums[cur] });
                    while (left < right && nums[left + 1] == nums[left])
                    {
                        left++;
                    }

                    while (left < right && nums[right - 1] == nums[right])
                    {
                        right--;
                    }

                    left++;
                    right--;
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }

            }

            return list;

        }

            public static int MyAtoi(string s)
        {
            var sb = new StringBuilder();

            var isPositive = (bool?)null;
            
            for (int j = 0; j < s.Length; j++)
            {
                var c = s[j];

                if ((c == ' ') && isPositive == null && sb.Length == 0) {
                    continue;
                }
                if (c == '-' || (c == '+')) {
                    if (sb.Length != 0) break;

                    if (isPositive == null) { isPositive = c == '+'; } else return 0;
                } else if (char.IsDigit(c))
                {
                    sb.Append(c);
                }
                else {                    
                    break;
                }
            }

            if (sb.Length == 0) return 0;

            if ((isPositive ?? true) == false) {
                sb.Insert(0, "-");
            }

            if (int.TryParse(sb.ToString(), out int res))
            {
                return res;
            }

            return (isPositive ?? true == false) ? int.MaxValue : int.MinValue;
        }

        public static int common(string a, string b)
        {
            var matrix = new int[a.Length + 1, b.Length + 1];

            for (var ap = 1; ap <= a.Length; ap++)
            {
                for (var bp = 1; bp <= b.Length; bp++)
                {
                    if (a[ap-1] == b[bp-1])
                    {
                        matrix[ap, bp] = 1 + matrix[ap - 1, bp - 1];
                    }
                    else {
                        matrix[ap, bp] = Math.Max(matrix[ap - 1, bp], matrix[ap, bp - 1]);
                    }
                }
            }

            CodeUtils.PrintMatrix(matrix);
            return matrix[a.Length, b.Length];
        }
    }
}
