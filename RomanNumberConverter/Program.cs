using RomanNumberParser.BusinessObject;
using RomanNumberParser.Services;
using System;

namespace RomanNumberParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var rNuber = new RomanNumber();
            rNuber.Number = "MMMCDLXXVIII";

            var converter = new ParserService();
            int solution = converter.Parse(rNuber);

            Console.WriteLine("This converter is working only with correct format of roman numbers. It does not check the correctness of roman number.");
            Console.Write("Roman Number: "); Console.Write(rNuber.Number); Console.Write(" is "); Console.Write(solution);
        }
    }
}
