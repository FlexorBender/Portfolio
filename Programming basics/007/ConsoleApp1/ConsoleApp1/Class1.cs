using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class PrString
    {
        public static void GetWord(char[] s, ref int l, ref int r)
        {
            while (l < s.Length && !Letter(s[l]))
            {
                l++;
            }
            r = l;
            while (r < s.Length && Letter(s[r]))
            {
                r++;
            }
        }
        public static int SummLetters(char[] s)
        {
            int result = 0;
            foreach (char c in s)
            {
                if (Letter(c))
                {
                    result++;
                }
            }
            return result;
        }

        public static double AverageWordLength(char[] s)
        {
            double countLetters = 0;
            int countWords = 0;
            int l = 0;
            int r = 0;
            while (l < s.Length)
            {
                GetWord(s, ref l, ref r);
                countLetters += r - l;
                countWords++;
                l = r + 1;
            }
            if (countWords == 0) return -1.0;
            return countLetters / countWords;
        }

        public static String ChangeString(String s, String rep, String ins)
        {
            int l = 0;
            while (l < s.Length)
            {
                String s2 = s.Substring(l);
                int r = s2.IndexOf(rep);
                if (r < 0)
                {
                    break;
                }
                String s1 = s2.Substring(r);

                if ((s1.Length == rep.Length || !Letter(s1.ElementAt(rep.Length))) && (l == 0 || !Letter(s.ElementAt(l + r - 1))))
                {
                    s = s.Insert(l + r, ins);
                    l += r + ins.Length;
                    s = s.Remove(l, rep.Length);
                }
                else
                {
                    l += r + rep.Length;
                }
            }
            return s;
        }
      
        public static Boolean Letter(char c)
        {
            return (('a' <= c && c <= 'z') || ('A' <= c && c <= 'Z') || ('а' <= c && c <= 'я') || ('А' <= c && c <= 'Я'));
        }

        public static int CountSubstrings(String s, String subs)
        {
            int result = 0;
            for (int i = 0; i < s.Length - subs.Length + 1; ++i)
            {
                if (s.Substring(i, subs.Length).ToUpper().Equals(subs.ToUpper()))
                {
                    result++;
                }
            }
            return result;
        }

        public static bool Palindrome(String s)
        {
            String s1 = s.ToLower();

            s = "";

            for (int i = 0; i < s1.Length; ++i)
            {
                if (Letter(s1.ElementAt(i)))
                {
                    s += s1.ElementAt(i);
                }
            }
            for (int i = 0; i < s.Length / 2; ++i)
            {
                if (s.ElementAt(i) != s.ElementAt(s.Length - 1 - i))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Date(String s)
        {
            String[] arr = s.Split('.');
            if (arr.Length != 3)
            {
                return false;
            }

            for (int i = 0; i < 3; ++i)
            {
                try
                {
                    int n = Int32.Parse(arr[i]);
                    if (i == 0)
                    {
                        if (n < 1 || n > 31)
                        {
                            return false;
                        }
                    }
                    if (i == 1)
                    {
                        if (n < 1 || n > 12)
                        {
                            return false;
                        }
                    }
                    if (i == 2)
                    {
                        if (arr[i].Length != 4 && arr[i].Length != 2)
                        {
                            return false;
                        }
                    }
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }
    }

}