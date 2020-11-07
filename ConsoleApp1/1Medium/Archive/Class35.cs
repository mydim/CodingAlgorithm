using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class35
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

            Dictionary<int, string> birds = new Dictionary<int, string>() {
            
            {1,"Tundra Swan"},
            {2,"Hawaiian Goose"},
            {3,"Egyptian Goose"},
            {4,"Orinoco Goose"},
            {0,"Andean Goose"}
        };

            LRUCache(2);

            //     ["LRUCache","put","put","get","put","get","put","get","get","get"]
            //[[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]
            Put(1, 1);
            Put(2, 2);
            Get(1);
            Put(3, 3);
            Get(2);
            Put(4, 4);
            Get(1);
            Get(3);
            Get(4);







            //    var b = common("I was here", "I have been here");


            Console.ReadLine();
        }

        public class Node
        {
            public int Value;
            public Node Prev;
            public Node Next;

            public Node(int value)
            {
                this.Value = value;
            }
        }

        static int capacity;

        //key, <key, value>
        static Dictionary<int, Node> cache;

        //key, values
        static Node head = null;
        static Node tail = null;


        public static void LRUCache(int capacit)
        {
            cache = new Dictionary<int, Node>();

            capacity = capacit;
        }

        public static int Get(int key)
        {
            Console.WriteLine("get > " + key);
            if (cache.TryGetValue(key, out Node node))
            {
                Console.WriteLine("get:return > " + node.Value);
                MarkAsUsed(node);                
                return node.Value;
            }
            return -1;
        }

        public static void Put(int key, int value)
        {
            if (cache.TryGetValue(key, out Node node))
            {
                node.Value = value;
                MarkAsUsed(node);
            }
            else
            {
                node = new Node(value);
                if (cache.Count == capacity)
                {
                    //last least recently used key remove
                    RemoveFirstNode();
                    cache.Remove(key);
                }

                MarkAsUsed(node);
                cache.Add(key, node);
            }
        }

        static void MarkAsUsed(Node node)
        {
            //// tail
            if (node != tail)
            {

                // new node
                if (node.Next == null && node.Prev == null)
                {
                    if (tail != null)
                    {
                        tail.Next = node;
                        node.Prev = tail;
                    }
                }
                else if (node == head)
                {
                    head = node.Next;
                    if (node.Next != null && node.Next != head)
                    {
                        node.Next.Prev = head;
                    }

                }
                else
                {
                    // remove node from cur position
                    //0  ---   1 --- 2
                    //0 (prev)   --- 2 (next)

                    var prev = node.Prev;
                    var next = node.Next;

                    // head or middle
                    if (prev != null)
                    {
                        prev.Next = next;
                    }

                    if (next != null)
                    {
                        next.Prev = prev;
                    }

                    //put to the end
                    if (tail != null)
                    {
                        tail.Next = node;
                        node.Prev = tail;
                    }
                }

                node.Next = null;
                tail = node;

                if (head == null)
                {
                    head = tail;
                }
            }

            var h = head;
            var sb = new StringBuilder();
            while (h != null) {
                sb.Append(h.Value + ", ");
                h = h.Next;
            }
            Console.WriteLine(sb.ToString());

        }

        static void RemoveFirstNode()
        {
            var newHead = head.Next;
            if (newHead != null)
            {
                newHead.Prev = null;
            }

            head = newHead;
        }
    }
}
