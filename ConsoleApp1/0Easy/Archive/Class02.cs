using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Utils
    {
        private static DateTime timer;
        public static void TimerRestart()
        {
        

            timer = DateTime.Now;
        }
        public static void TimerWriteLine()
        {
            Console.WriteLine();
            Console.WriteLine("Time: " + (DateTime.Now - timer).TotalMilliseconds + " ms");
        }  

        public static void PrintNode(ListNode head)
        {
            var s = "";
            var cnt = 0;

            if (head != null)
                cnt = 1;

            var next = head;
            while (next != null)
            {

                s = s + ", '" + next.value.ToString() + "'";
                cnt++;
                next = next.next;
            }


            s = s + " /Count:" + cnt;
            Console.WriteLine(s);
        }
    }

    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int x)
        {
            value = x;
        }
    }

  
    public static class Class02
    {

        public static void RunCode()
        {
            var head = new ListNode(1);
            var ln = head;

            var cn = new ListNode(2); ln.next = cn; ln = cn;
            cn = new ListNode(3); ln.next = cn; ln = cn;
            cn = new ListNode(4); ln.next = cn; ln = cn;
            cn = new ListNode(5); ln.next = cn; ln = cn;
            cn = new ListNode(6); ln.next = cn; ln = cn;
            cn = new ListNode(7); ln.next = cn; ln = cn;


            var reversedLN = head;
            Utils.PrintNode(head);

            var next = head.next;
            head.next = null;

            while (next != null)
            {
                //11, 12, 13 
                // 2, 3,  null 

                //13, 12, 11
                //2, 3, null
                var linkForNext = next.next;

                var temp = reversedLN;
                reversedLN = next;
                reversedLN.next = temp;


                next = linkForNext;
                
            }
            Utils.PrintNode(reversedLN);


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
            //Console.Write("");
            //Console.ReadLine();

            //return ;
        }


    }
}
