using DataUtilites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validatores
{
    public class FIOValidator:Validator<string>
    {
        public FIOValidator()
        {
            AddRule(fio => !Regex.IsMatch(fio, Paterns.RuCharsAndSpaces), "ФИО содержит недопустимые символы");

        }
    }
}
