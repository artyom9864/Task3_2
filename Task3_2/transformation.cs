using System;
using Task3_2;
namespace Task3_2
{
    public class transformation
    {
        private static int CharToInt(char c)
        {
            return c - '0';
        }
        public static int ToInt(string s)
        {
            if (s == null) throw new ArgumentException();
            if (s.Length == 0) throw new ArgumentException();

            bool isNegative = false;
            int start = 0;

            switch (s[0])
            {
                case '-':
                    if (s.Length == 1) throw new ArgumentException();
                    start = 1;
                    isNegative = true;
                    break;
                case '+':
                    if (s.Length == 1) throw new ArgumentException();
                    start = 1;
                    break;
            }
            int result = 0;

            for (int i = start; i < s.Length; i++)
            {
                if (i < '0' || i > '9') throw new ArgumentException();
                result = checked(result * 10 + CharToInt(s[i]));
            }
            return (isNegative) ? -result : result;
        }
    }
}

