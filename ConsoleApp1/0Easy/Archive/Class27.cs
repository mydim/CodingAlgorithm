using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class27
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

         //  var b = MaxDepthOfTree(root);
            //Console.WriteLine(b);
            Console.ReadLine();
        }

        public static ListNode ReverseList(ListNode head)
        {
            //Input: 1->2->3->4->5->NULL
            // Output: 5->4->3->2->1->NULL

            //1
            //    next 2
            //        next 3
            //                    next null

            //3 
            //  next 2
            //      next 1
            //          next null           

            ListNode prev = null;

            while (head!=null)
            {
                var nextNode = head.next;
                head.next = prev;
                prev = head;
                head.next = nextNode;
            }

            do
            {
                //head = 1
                //head.next = 2
                //cur = 2
                var currNext = head.next;

                //1.next = null
                head.next = prev;

                //prev = 2 
                prev = head;

                //head = 2
                head = currNext;
            }
            while (head != null);

            return head;

        }

        public class ListNode
        {
            public int data;
            public ListNode next;
        }

    }

   
}
