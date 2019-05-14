using System;

namespace RomanToInteger
{
    class RomanToInteger
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Romen rakamı giriniz");
                var roman = Console.ReadLine();
                Console.WriteLine(ConvertRoman(roman));
            }
        }

        static int ConvertRoman(string s)
        {
            int total = 0;
            s = s.ToUpper();

            for (int i = 0; i < s.Length; i++)
            {
                var character = s[i];
                if (i != s.Length - 1 && RomanValue(s[i]) < RomanValue(s[i + 1]))
                {
                    total += RomanValue(s[i + 1]) - RomanValue(s[i]);
                    i++;
                    continue; ;
                }
                else
                {
                    total += RomanValue(s[i]);
                }
            }

            return total;

        }

        static int RomanValue(char c)
        {
            switch (c)
            {
                case 'I':
                    return (int)RomanNumbers.I;
                case 'V':
                    return (int)RomanNumbers.V;
                case 'X':
                    return (int)RomanNumbers.X;
                case 'L':
                    return (int)RomanNumbers.L;
                case 'C':
                    return (int)RomanNumbers.C;
                case 'D':
                    return (int)RomanNumbers.D;
                case 'M':
                    return (int)RomanNumbers.M;
                default:
                    return 0;
            }
        }

    }

    enum RomanNumbers
    {
        I = 1,
        V = 5,
        X = 10,
        L = 50,
        C = 100,
        D = 500,
        M = 1000
    }

}
