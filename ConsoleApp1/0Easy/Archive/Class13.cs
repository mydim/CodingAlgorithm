using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class13
    {
        public class Range
        {
            public int Min, Max;
                        
            public Range(int min, int max)
            {
                min = Min;
                max = Max;
            }

            public int Length { get { return Max - Min; } }

            public bool IsOverlap(Range r)
            {               
                return Range.IsValueInRage(this, r.Min) || Range.IsValueInRage(this, r.Max);
            }

            public static bool IsValueInRage(Range range, int val)
            {
                //---MxxxxxxxxxxxxxxxM--
                //---vvvvvvvvvvvvvvvvv--
                return range.Min > val && val <= range.Max;
            }

        }


        public class LinkedRange
        {
            public Range Range;
            public LinkedRange Pointer;
    
      

            public Range AddRange(Range from)
            {
                if (this.Range == null) //first element add
                {
                    this.Range = from;
                    return from;
                }

                var nextPointer = this;
                var largestRage = nextPointer.Range;

                while (nextPointer != null)
                {

                    //var isOverlaped = IsOverlap(nextPointer.Range, from.Min) || IsOverlap(nextPointer.Range, from.Max);

                    //S1 E1
                    //S2 E2

                    //case1 //equal = > ingore
                    //xxxxx
                    //yyyyy                   

                    //case2 //ends => expetion
                    //xxxxx
                    //-yyyy                   

                    //case3 //begins => expetion
                    //xxxxx
                    //yyyy-                  

                    //case4//contain => expetion
                    //xxxxx
                    //-yyy-                                  

                    //case5//no overlap, add left or right pointer
                    //----xxxxx----
                    //---------yyyy
                    //yyyy---------

                    //if overlaping throw exception
                    throw new Exception("overlaping throw exceptions");

                    //check next
                    nextPointer = nextPointer.Pointer;
                }

                return largestRage;
            }
        }

        //        There will be a list of ranges.Find largest missing ranges.If there is overlaping throw exceptions.

        //Input
        //10, 20
        //21, 50
        //100, 200

        //Output
        //51, 99

        //private static void GetLargestMissingRange(List<Range> l)
        //{
        //    var lr = new LinkedRange(); //begining

        //    Range largestRange = null;

        //    foreach (var item in l)
        //    {
        //        var bigRange = lr.AddRange(item);
        //    }
        //}


        private static Range GetLargestRangeNotFilled(List<Range> list)
        {
            //var l = list.OrderBy(x => x.Min).ToList();
            var l = list;

            Range largestRange = null;            

            Range last = l[0];

            for (int i = 1; i < l.Count; i++)
            {
                if (l[i].IsOverlap(last))                
                    throw new Exception("overlaping throw exceptions");                
                else
                {
                    var notFilledRange = new Range(last.Max + 1, l[i].Min - 1);

                    if (
                            (largestRange == null) ||
                            (notFilledRange.Length > largestRange.Length)
                        )
                        largestRange = notFilledRange;
                }
            }

            return largestRange;
        }


        public static void RunCode()
        {
            var l = new List<Range>();

            l.Add(new Range(10, 20));
            l.Add(new Range(21, 50));
            l.Add(new Range(100, 200));

            //GetLargestMissingRange(l);
        }

    
    }
}
