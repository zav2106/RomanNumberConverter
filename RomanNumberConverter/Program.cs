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

            Console.WriteLine("This converter is working only with correct format of roman numbersгтвук 4000. It does not check the correctness of roman number.");
            Console.Write("Roman Number: "); Console.Write(rNuber.Number); Console.Write(" is "); Console.Write(solution); Console.WriteLine();

             var rNuber1 = new RomanNumber();
            rNuber1.Number = "MCMXCVII";

            var rNuber2 = new RomanNumber();
            rNuber2.Number = "MMCDXCVIII";
            int convertedNumber1;
            int convertedNumber2;

            convertedNumber2 = converter.Parse(rNuber2);
            convertedNumber1 = converter.Parse(rNuber1);

            if (convertedNumber1 == 1997)
            {
                Console.WriteLine("Unit Test with MCMXCVII=1997 is successfull");
            }

            if (convertedNumber2 == 2498)
            {
                Console.WriteLine("Unit Test with MMCDXCVIII=2498 is successfull");
            }
        }
    }
}
