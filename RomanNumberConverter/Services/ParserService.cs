using RomanNumberParser.BusinessObject;
using RomanNumberParser.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumberParser.Services
{
    public class ParserService : IParser
    {
        private readonly char M = 'M';
        private readonly char D = 'D';
        private readonly char C = 'C';
        private readonly char L = 'L';
        private readonly char X = 'X';
        private readonly char V = 'V';
        private readonly char I = 'I';
        private int sum = 0;
        private string rn;
        public int Parse(RomanNumber romanNumber)
        {
            sum = 0;
            rn = romanNumber.Number;
            for (var i = 0; i < romanNumber.Number.Length; i++)
            {
                if (i + 1 == romanNumber.Number.Length)
                {
                    sum = sum + RomanNumberEquivalent(rn[i]);
                    return sum;
                }
                else
                {
                    if (RomanNumberEquivalent(rn[i]) == RomanNumberEquivalent(rn[i + 1]))
                    {
                        sum = sum + RomanNumberEquivalent(rn[i]);
                    }
                    if (RomanNumberEquivalent(rn[i]) > RomanNumberEquivalent(rn[i + 1]))
                    {
                        sum = sum + RomanNumberEquivalent(rn[i]);
                    }
                    if (RomanNumberEquivalent(rn[i]) < RomanNumberEquivalent(rn[i + 1]))
                    {
                        sum = sum - RomanNumberEquivalent(rn[i]) + RomanNumberEquivalent(rn[i + 1]);
                        i++;
                    }
                }
            }
            return sum;
        }

        private int RomanNumberEquivalent(char ch)
        {
            if (ch == M) { return 1000; }
            if (ch == D) { return 500; }
            if (ch == C) { return 100; }
            if (ch == L) { return 50; }
            if (ch == X) { return 10; }
            if (ch == V) { return 5; }
            if (ch == I) { return 1; }
            return 0;
        }


    }
}
