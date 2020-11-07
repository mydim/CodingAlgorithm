using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
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

            var list1 = new string[][]
                    {
                        new string[] { "10:00", "11:00" },
                        new string[] { "13:00", "14:00" },
                        new string[] { "16:00", "17:00" },
                        new string[] { "17:30", "19:00" },
                    };

            var list2 = new string[][]
                    {
                        new string[] { "9:30", "12:00" },
                        new string[] { "13:00", "14:30" },
                        new string[] { "16:00", "17:00" },
                        new string[] { "17:00", "18:00" },
                    };

            var b = common(list1, list2, 30);

            //    var b = common("I was here", "I have been here");
         //   Console.WriteLine(string.Join(", ", b.ToArray()));


            //Console.WriteLine(b);

            Console.ReadLine();
        }

        private static List<Tuple<string, string>> common(string[][] list1, string[][] list2, int dur)
        {
            var globalStart = "9:00";
            var globalEnd = "20:00";
            var globalStartInMinutes = getMinutes(globalStart);
            var globalEndInMinutes = getMinutes(globalEnd);

            var maxEvents = (globalEndInMinutes - globalStartInMinutes) / dur;
            var available = new bool[maxEvents];
            for (int i = 0; i < available.Length; i++)
            {
                available[i] = true;
            }

            markAvailable(available, list1, globalStartInMinutes, globalEndInMinutes, dur);
            markAvailable(available, list2, globalStartInMinutes, globalEndInMinutes, dur);

            var res = new List<Tuple<string, string>>();

            return res;
        }

        private static void markAvailable(bool[] available, string[][] list, int globalStartInMinutes, int globalEndInMinutes, int dur)
        {
            foreach (var item in list)
            {
                var s = item[0];
                var start = getMinutes(s);
                var e = item[1];
                var end = getMinutes(e);
                end = end > globalEndInMinutes ? globalEndInMinutes : end;


                var startTimeIndex = (start - globalStartInMinutes) / dur;
                var endTimeIndex = (end - globalStartInMinutes) / dur;
                for (int i = startTimeIndex; i < endTimeIndex; i++)
                {
                    available[i] = false;
                }
            }
        }

        private static int getMinutes(string time)
        {
            var sepIndex = time.IndexOf(":");

            var hrMin = int.Parse(time.Substring(0, sepIndex)) * 60;
            var min = int.Parse(time.Substring(sepIndex + 1));
            return hrMin + min;
        }

        private static string getMinutesInString(int time)
        {
            var hr = time / 60;
            var min = time % 60;
            
            return hr+":"+min.ToString("00");
        }

    }
}
