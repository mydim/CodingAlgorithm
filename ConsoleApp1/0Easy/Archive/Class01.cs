using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class01
    {
        public static void RunCode()
        {

            MyCalendarThree();

            Book(26, 35);
            Book(26, 32);
            Book(25, 32);
            Book(18, 26);
            Book(40, 45);

            int N = 5 + 5;
            var arr7 = new int[N];
            var arr8 = new int[] { 1, 2, 3 };
            int[] arr9 = { 1, 2, 3 };

            if ('8' > '1')
                Console.Write("1>8");
        }


        static List<KeyValuePair<int, int>> _books;
        public static void MyCalendarThree()
        {
            _books = new List<KeyValuePair<int, int>>();
        }

        public static int Book(int start, int end)
        {
            if (end < start)
                return 0;


            _books.Add(new KeyValuePair<int, int>(start, end));

            var cnt = 0;
            foreach (var p in _books)
            {
                //      >start or end<
                //  Key  ---------  Value

                if (
                        ((start >= p.Key) && (start <= p.Value)) ||
                        ((end <= p.Value) && (end >= p.Key))
                    )
                    cnt++;
            }


            if (cnt > 3)
                return 3;
            return cnt;
        }
    }
}
