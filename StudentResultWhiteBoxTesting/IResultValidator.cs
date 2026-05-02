using System;
using System.Collections.Generic;
using System.Text;

namespace StudentResultWhiteBoxTesting
{
    internal interface IResultValidator
    {
        bool ValidateMark(int mark);
    }
}
