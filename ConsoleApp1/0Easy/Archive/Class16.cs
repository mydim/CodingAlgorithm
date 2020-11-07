using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class16
    {
        public static ListNode SwapPairs(ListNode head)
        {

            ListNode parentEl = null;
            ListNode firstEl = head;

            while (firstEl != null)
            {
                if (firstEl.next == null)
                    break;

                var secondEl = firstEl.next;

                //p > 1 | 1 > 2 | 2 > 3
                //p > 2 | 2 > 1 | 1 > 3

                if (parentEl != null)
                    parentEl.next = secondEl;
                else
                    head = secondEl;

                var thirdEl = secondEl.next;
                secondEl.next = firstEl;

                firstEl.next = thirdEl;

                parentEl = firstEl;
                firstEl = thirdEl;
            }

            return head;
        }
    }
}
