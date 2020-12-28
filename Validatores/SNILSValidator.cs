using DataUtilites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validatores
{
    public class SNILSValidator : Validator<string>
    {
        public SNILSValidator()
        {
            AddRule(snils => !Regex.IsMatch(snils, Paterns.Snils), "СНИЛС не коректен");
        }
    }
}
