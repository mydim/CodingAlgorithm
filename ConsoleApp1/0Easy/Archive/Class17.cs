using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy
{
    public static class Class17
    {
        public static int StrStr(string haystack, string needle)
        {
            if (needle == "")
                return 0;


            for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool isMatch = true;

                    for (int j = 1; j < needle.Length; j++)
                    {
                        if (haystack.Length == i + j)
                        {
                            isMatch = false;
                            break;
                        }

                        if (haystack[i + j] != needle[j])
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }
    }
}
