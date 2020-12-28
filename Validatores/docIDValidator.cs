using DataUtilites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validatores
{
    public class docIDValidator : Validator<string>
    {
        public docIDValidator()
        {
            AddRule(id=> !Regex.IsMatch(id, Paterns.Identificator),"Ваш идентификатор содержит недопустимые символы или более 5 знаков");
        }
    }
}
