using OpenNLP.Tools.SentenceDetect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class49
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


            //  var a = "This is how I tried look at 1.1. ref and to split a paragraph into a sentence. HP E2B16UT Mini-tower Workstation - 1 x Intel Xeon E3-1245V3 3.40 GHz. Hello, you are welcome. StackOverflow. some_email@hotmail.com. But, there is a problem. My paragraph includes dates like Jan.13, 2014 , words like U.S and numbers like 2.2. They all got split by the above code.";
            var a = "We use structuralism and functionalism paradigms to analyze the origins of big data applications.Current trends and sources of big data.Processing technologies, methods and analysis techniques for big data are compared in detail.We analyze major challenges with big data and also discussed several opportunities.Case studies and emerging technologies for big data problems are discussed. Big data is a potential research area receiving considerable attention from academia and IT communities. In the digital world, the amounts of data generated and stored have expanded within a short period of time. Consequently, this fast growing rate of data has created many challenges. In this paper, we use structuralism and functionalism paradigms to analyze the origins of big data applications and its current trends. This paper presents a comprehensive discussion on state-of-the-art big data technologies based on batch and stream data processing. Moreover, strengths and weaknesses of these technologies are analyzed. This study also discusses big data analytics techniques, processing methods, some reported case studies from different vendors, several open research challenges, and the opportunities brought about by big data. The similarities and differences of these techniques and technologies based on important parameters are also investigated. Emerging technologies are recommended as a solution for big data problems. ";

            //var a = "The value of the examination was 10.4 nm. The red fox (what was he thinking!?) jumped over the brown cow.";
            common(a);
            //Console.WriteLine("++++++++++++++++++++++");

            var paragraph = a;// "Mr. & Mrs. Smith is a 2005 American romantic comedy action film. The film stars Brad Pitt and Angelina Jolie as a bored upper-middle class married couple. They are surprised to learn that they are both assassins hired by competing agencies to kill each other.";
            var modelPath = @"B:\10. Career.Next\2. Prepare for Interview\CodingAlgorithm\ConsoleApp1\en-sent.bin";
            var sentenceDetector = new EnglishMaximumEntropySentenceDetector(modelPath);
            var sentences = sentenceDetector.SentenceDetect(paragraph);
            foreach (var s in sentences)
            {
                Console.WriteLine(s);
            }

            //    var b = common("I was here", "I have been here");

            //  Console.WriteLine(b);

            Console.ReadLine();
        }

        public static void common(string message)
        {            
            var sentences = Regex.Split(message, "(?<=[.!?])\\s* ");
            foreach (var s in sentences)
            {
                Console.WriteLine(s);
            }
        }
    }
}
