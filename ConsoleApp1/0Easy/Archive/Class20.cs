using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Easy
{
    public static class Class20
    {
    //    929. Unique Email Addresses
    //Easy

    //340

    //98

    //Favorite

    //Share
    //Every email consists of a local name and a domain name, separated by the @ sign.

    //For example, in alice @leetcode.com, alice is the local name, and leetcode.com is the domain name.

    //Besides lowercase letters, these emails may contain '.'s or '+'s.

    //If you add periods ('.') between some characters in the local name part of an email address, mail sent there will be forwarded to the same address without dots in the local name.For example, "alice.z@leetcode.com" and "alicez@leetcode.com" forward to the same email address.  (Note that this rule does not apply for domain names.)

    //If you add a plus('+') in the local name, everything after the first plus sign will be ignored.This allows certain emails to be filtered, for example m.y+name @email.com will be forwarded to my@email.com.  (Again, this rule does not apply for domain names.)

    //It is possible to use both of these rules at the same time.

    //Given a list of emails, we send one email to each address in the list.How many different addresses actually receive mails? 




    //Example 1:

    //Input: ["test.email+alex@leetcode.com","test.e.mail+bob.cathy@leetcode.com","testemail+david@lee.tcode.com"]
    //Output: 2
    //Explanation: "testemail@leetcode.com" and "testemail@lee.tcode.com" actually receive mails


    //Note:

    //1 <= emails[i].length <= 100
    //1 <= emails.length <= 100
    //Each emails[i] contains exactly one '@' character.

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
            var i = 0;
            for(;i<1;i++)
            { }

            //Console.WriteLine(b);
            Console.ReadLine();
        }

        public static string GetEmail(string email)
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 1; j < email.Length; j++)
            {
                char c = email[j];
                if (c == '.')
                {
                    continue;
                }

                if (c == '+')
                {
                    j = email.IndexOf('@', j + 1);
                    c = '@';
                }

                if (c == '@')
                {
                    for (int i = j; i < email.Length; i++)
                    {
                        sb.Append(email[i]);
                    }
                    break;
                }

                sb.Append(c);
            }

            return sb.ToString();
        }

        public static int NumUniqueEmails(string[] emails)
        {
            HashSet<string> uEmails = new HashSet<string>();
            foreach (string email in emails)
            {
                uEmails.Add(GetEmail(email));
            }

            return uEmails.Count;
        }

    }
}
