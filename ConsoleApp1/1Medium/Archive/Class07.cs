using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class07
    {
        //    535. Encode and Decode TinyURL
        //Favorite

        //Share
        //Note: This is a companion problem to the System Design problem: Design TinyURL.
        //TinyURL is a URL shortening service where you enter a URL such as https://leetcode.com/problems/design-tinyurl and it returns
        //a short URL such as http://tinyurl.com/4e9iAk.

        //Design the encode and decode methods for the TinyURL service.There is no restriction on how your encode/decode algorithm should work.
        //You just need to ensure that a URL can be encoded to a tiny URL and the tiny URL can be decoded to the original URL.

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

            //Console.WriteLine(b);
            Console.ReadLine();
        }

        static Dictionary<string, string> table = new Dictionary<string, string>();

        public static string encode(string longUrl)
        {
            var res = Convert.ToString(longUrl);
            table.Add(res, longUrl);
            return res;
        }

        public static string decode(string shortUrl)
        {
            var longURL = table[shortUrl];
            return longURL;
        }

        // Your Codec object will be instantiated and called as such:
        // Codec codec = new Codec();
        // codec.decode(codec.encode(url));

    }
}
