using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class36
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

            var t = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Test1();
            }
            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);

            t = DateTime.Now;
            for (int i = 0; i < 10000; i++)
            {
                Test2();
            }
            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);




            var a1 = "test";
            var b1 = a1;
            a1 = "test123";

            var dict = new Dictionary<string, int>();
            dict["test"] = 1;

      

            //var a = new StringBuilder();
            var a = "!Open data + (\\W+) offers W a + a new start for economic reform and productivity growth. Leveraging the new possibilities of the Internet to make better use of existing resources, it offers us a way of getting past the political economy of winners and losers. This report illustrates the potential economic value of reinvigorating the open data agenda in Australia and the G20. Our review of the literature, our modeling, and our case study scenarios show how an open data focus could promote the themes of the G20 agenda—trade, finance, fiscal and monetary policy, anti-corruption, employment, energy, and infrastruc - ture—and in so doing achieve more than half of the G20’s 2% growth target. Scaling recent results of the McKinsey Global Institute suggests that implementation of open data policies including in areas corresponding to G20 agenda items could increase G20 output by around USD 13 trillion over the next five years. This would boost cumulative G20 GDP by around 1.1 percent - age points of the 2% growth target over five years. Similar scaling for Australia suggests that more vigorous open data policies could add around AUD 16 billion per annum to the Australian economy. The modeling and case studies in this report validate the magnitude of that figure and suggest that it may underestimate the potential value of open data. VALUE CREATION The more data is opened, the more it can be used, reused, repurposed and built on—in combination with other data—for everyone’s benefit. As our econ - omy and society become more knowledge-based, data are core assets, creating value in their own right and driving social and economic innovation, growth and development. Opening data creates social and economic value in myriad ways by: • Reducing costs in the provision of existing services both by government and private sector (i.e. doing the same for less cost); • Enabling new services and improved quality of services; and • Indirectly contributing to improvements in governance and government services through improved accountability and citizen involvement, both of which engender greater trust in government. This report explicates these mechanisms";
            var dddd = Regex.Replace(a ?? "", "@\\d+", "");

            var ccc = "Open *\\W a + a + * data + offers a new start for economic reform and productivity growth.";
            var res = HighlightSubPhrase(ccc, "*\\W a + a + *");
            //var res = HighlightSubPhrase(ccc, "\\W +");
            Console.WriteLine(res);



            var a2 = a;
            var h = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            h.Add("Global");
            h.Add("Institute");
            h.Add("McKinsey");
            h.Add("Big");
            h.Add("G20");
            h.Add("data");
            h.Add("productivity");
            h.Add("veracity");
            h.Add("mechanisms");
            h.Add("growth");
            h.Add("trajectory");
            h.Add("MGI");
            h.Add("citizen");
            h.Add("and");
            h.Add("Open");

            if (h.Contains(null))
            { 
            }

            var res1 ="";
            var res2 = "";
            t = DateTime.Now;
            //3558
            for (int i = 0; i < 1000; i++)
            {
                res1 = HighlightSubPhrase(a, h);
            }
            Console.WriteLine((DateTime.Now-t).TotalMilliseconds);

            ///
            t = DateTime.Now;
            var gl = 0;

            //3558
            for (int i = 0; i < 1000; i++)
            {
                foreach (var h1 in h)
                {
                    if (a.Contains(h1))
                    {
                        gl++;
                    }
                }
                res1 = HighlightSubPhrase(a, h);
            }
            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);
            ///


            t = DateTime.Now;
            //3558
            for (int i = 0; i < 1000; i++)
            {
                res2 = a2;
                foreach (var h1 in h)
                {
                    res2 = HighlightSubPhrase(res2, h1);
                }
                
            }            
            Console.WriteLine((DateTime.Now - t).TotalMilliseconds);
            var s2 = a2;


            //    var b = common("I was here", "I have been here");

            //            Console.WriteLine(b);

            Console.ReadLine();
        }

        private static string Test2()
        {
            var subPhrase = "*\\W a +a + *";
            
            var subPhraseRegex = new System.Text.StringBuilder();
            var subWords = subPhrase.Split(' ');
            subPhraseRegex.Append(Regex.Escape(subWords[0]));
            for (int i = 1; i < subWords.Length; i++)
            {
                subPhraseRegex.Append("[\\p{P}\\s]+");
                subPhraseRegex.Append(Regex.Escape(subWords[i]));
            }

            return subPhraseRegex.ToString();
        }

        private static string Test1()
        {
            var subPhrase = "*\\W a +a + *";
            var tryMatchPhraseRegex = string.Join("[\\p{P}\\s]+", subPhrase.Split(' '));

            return tryMatchPhraseRegex;
        }

        //Global
        //Institute
        //McKinsey
        //Big
        //data
        //productivity
        //veracity
        //future
        //growth
        //trajectory
        //MGI
        //citizen
        //and
        //Open

        //M - matches
        //N - text size
        //O(M*N)
        //O(N*M)

        //!Open data offers a new start for economic reform and productivity growth.Leveraging 
        //the new possibilities of the Internet to make better use of existing resources, it offers 
        //us a way of getting past the political economy of winners and losers.This report illustrates the potential economic value of 
        //reinvigorating the open data agenda in Australia and the G20.Our review of the literature, our modeling, and our case study
        // scenarios show how an open data focus could promote the themes of the G20 agenda—trade, finance, fiscal and monetary policy,
        // anti-corruption, employment, energy, and infrastruc - ture—and in so doing achieve more than half of the G20’s 2% growth target. Scaling recent 
        //results of the McKinsey Global Institute suggests that implementation of open data policies including in areas corresponding to G20 agenda items 
        //could increase G20 output by around USD 13 trillion over the next five years. This would boost cumulative G20 GDP by around 1.1 percent - age points 
        //of the 2% growth target over five years.Similar scaling for Australia suggests that more vigorous open data policies could add around AUD 16 billion
        // per annum to the Australian economy.The modeling and case studies in this report validate the magnitude of that figure and suggest that it may
        // underestimate the potential value of open data.VALUE CREATION The more data is opened, the more it can be used, reused, repurposed and built on—in 
        //combination with other data—for everyone’s benefit. As our econ - omy and society become more knowledge-based, data are core assets, creating value
        // in their own right and driving social and economic innovation, growth and development.Opening data creates social and economic value in myriad ways 
        //by: • Reducing costs in the provision of existing services both by government and private sector(i.e.doing the same for less cost); • Enabling new 
        //services and improved quality of services; and • Indirectly contributing to improvements in governance and government services through improved 
        //accountability and citizen involvement, both of which engender greater trust in government.This report explicates these mechanisms

        public static string HighlightSubPhrase(string str, HashSet<string> match)
        {
            int wordStart = -1;
            int wordEnd = -1;
            char curChar;
            string curWord;

            var sb = new System.Text.StringBuilder();        
            for (int index = 0; index < str.Length; index++)
            {
                curChar = str[index];

                if (char.IsLetter(curChar) || char.IsDigit(curChar))
                {
                    if (wordStart == -1)
                    {
                        wordStart = index;
                        wordEnd = -1;
                    }
                    continue;
                }
                else
                {
                    if (wordEnd == -1)
                    {
                        wordEnd = index - 1;
                    }

                    if (wordStart != -1) //if have a word
                    {
                        curWord = str.Substring(wordStart, index - wordStart);
                        if (match.Contains(curWord))
                        {
                            sb.Append(HitHighlightElementStartTag);
                            sb.Append(curWord);
                            sb.Append(HitHighlightElementEndTag);
                        }
                        else
                        {
                            sb.Append(curWord);
                        }

                        wordStart = -1;
                    }
                }

                sb.Append(curChar);
            }

            if (wordStart != -1)
            {
                if (wordEnd == -1)
                {
                    wordEnd = str.Length;
                }
                curWord = str.Substring(wordStart, wordEnd - wordStart);
                if (match.Contains(curWord))
                {
                    sb.Append(HitHighlightElementStartTag);
                    sb.Append(curWord);
                    sb.Append(HitHighlightElementEndTag);
                }
            }
            sb.Replace(HitHighlightElementEndTag + ' ' + HitHighlightElementStartTag, " ");

            return sb.ToString();
        }


        /// <summary>
        /// The hit highlight feature tag name
        /// </summary>
        private const string HitHighlightTagName = "em";

        /// <summary>
        /// The hit highlight feature start tag
        /// </summary>
        private static readonly string HitHighlightElementStartTag = $"<{HitHighlightTagName}>";

        /// <summary>
        /// The hit highlight feature end tag
        /// </summary>
        private static readonly string HitHighlightElementEndTag = $"</{HitHighlightTagName}>";

        public static string HighlightSubPhrase(string phrase, string subPhrase)
        {
            if (string.IsNullOrEmpty(phrase) || string.IsNullOrEmpty(subPhrase))
            {
                return phrase;
            }

            // Special case when search by HitHighlightTagName, reverse highlight element tag
            if (subPhrase.Equals(HitHighlightTagName, StringComparison.OrdinalIgnoreCase))
            {
                phrase = phrase.Replace(HitHighlightElementStartTag, new string(HitHighlightElementStartTag.Reverse().ToArray()));
                phrase = phrase.Replace(HitHighlightElementEndTag, new string(HitHighlightElementEndTag.Reverse().ToArray()));
            }

            var subPhraseRegex = new StringBuilder();
            var subWords = subPhrase.Split(' ');
            subPhraseRegex.Append(Regex.Escape(subWords[0]));
            for (int i = 1; i < subWords.Length; i++)
            {
                subPhraseRegex.Append("[\\p{P}\\s]+");
                subPhraseRegex.Append(Regex.Escape(subWords[i]));
            }

            var newPhrase = Regex.Replace(phrase, $"(\\W|^)({subPhraseRegex})(\\W|$)", $"$1{HitHighlightElementStartTag}$2{HitHighlightElementEndTag}$3", RegexOptions.IgnoreCase);

            // Special case when search by HitHighlightTagName, reverse highlight element tag back
            if (subPhrase.Equals(HitHighlightTagName, StringComparison.OrdinalIgnoreCase))
            {
                newPhrase = newPhrase.Replace(new string(HitHighlightElementStartTag.Reverse().ToArray()), HitHighlightElementStartTag);
                newPhrase = newPhrase.Replace(new string(HitHighlightElementEndTag.Reverse().ToArray()), HitHighlightElementEndTag);
            }

            return newPhrase;
        }
    }

}
