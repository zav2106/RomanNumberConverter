using RomanNumberParser.BusinessObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumberParser.Interfaces
{
    public interface IParser
    {
        int Parse(RomanNumber romanNumber);
    }
}
