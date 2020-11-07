using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Medium
{
    public static class Class02
    {

        public static void RunCode()
        {
            var aaa = MyAtoi("1095502006p8");
            var i = int.Parse("2147483648");
        }


        public static int MyAtoi(string str)
        {

            if (str == null) return 0;
            if (str == "") return 0;


            ///define plus/minus
            var isPlus = true;
            var start = -1;
            var isDirectionDefined = false;

            for (var i = 0; i < str.Length; i++)
            {

                if (str[i] == ' ')
                {
                    if (isDirectionDefined) return 0;
                    continue;
                }

                if (str[i] == '0')
                {
                    isDirectionDefined = true;
                    continue;
                }

                if (str[i] == '+')
                {
                    if (isDirectionDefined) return 0;
                    isDirectionDefined = true;
                    continue;
                }

                if (str[i] == '-')
                {
                    if (isDirectionDefined) return 0;
                    isDirectionDefined = true;

                    isPlus = false;
                    continue;
                }

                if (char.IsDigit(str[i]))
                {
                    start = i;
                    break;
                }

                else return 0;
            }

            if (start == -1) return 0;





            var end = start;

            for (var i = start + 1; i < str.Length; i++)
            {

                if (char.IsDigit(str[i]))
                    end = i;
                else
                    break;

            }

            if (start > end) return 0;

            //91283472332        
            var res = (isPlus ? "" : "-") + str.Substring(start, end - start + 1);





            var maxCharCount = 10 + (isPlus ? 0 : 1);
            if (res.Length > maxCharCount)
                return (!isPlus ? int.MinValue : int.MaxValue);
            if (res.Length == maxCharCount)
            {
                var a = new[] { '2', '1', '4', '7', '4', '8', '3', '6', '4', isPlus ? '7' : '8' };

                start = (isPlus ? 0 : 1);
                for (var i = start; i < res.Length; i++)
                {
                    if (
                        isPlus ? ((res[i] > a[i - start])) : (res[i] < a[i - start])
                        )
                        return (!isPlus ? int.MinValue : int.MaxValue);
                }


            }

            return int.Parse(res);


        }
    }
}
