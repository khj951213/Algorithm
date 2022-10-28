using System;
namespace StringCollection
{
    public class ReverseString
    {
        private static char[]? res;

        public static string Build(string s)
        {
            res = new char[s.Length];
            for(int i = 0; i < s.Length; i++)
            {
                res[i] = s[s.Length - i -1];
            }

            return new string(res);
        }
    }
}

