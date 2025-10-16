using System;

namespace Lab5.Model
{
    public class AgeChecker
    {
        public string CheckAgeCategory(int age)
        {
            if (age < 0)
                return "Вік не може бути від'ємним";
            else if (age < 13)
                return "Дитина";
            else if (age < 18)
                return "Підліток";
            else if (age < 65)
                return "Дорослий";
            else
                return "Літня людина";
        }
    }
}