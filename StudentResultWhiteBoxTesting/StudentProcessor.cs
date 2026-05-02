using System;
using System.Collections.Generic;
using System.Text;

namespace StudentResultWhiteBoxTesting
{
    class StudentProcessor : IResultValidator, IResultCalculator, IGradeCalculator
    {
        public bool ValidateMark(int mark)
        {
            if (mark < 0 && mark > 100)
                return false;

            return true;
        }

        public string CalculateResult(int mark)
        {
            if (mark > 50)
                return "Passed";
            else
                return "Failed";
        }
        public string AssignGrade(int mark)
        {
            if (mark >= 80)
                return "A";
            else if (mark >= 70)
                return "B";
            else if (mark >= 60)
                return "C";
            else if (mark >= 40)
                return "D";
            else
                return "F";
        }
    }
}
