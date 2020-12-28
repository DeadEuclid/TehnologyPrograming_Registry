using DataUtilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TehnologyProgramingModels;

namespace Validatores
{
    public class SpecialistValidator:Validator<Specialist>
    {
        Validator<string> FIOValidator = new FIOValidator();
        Validator<string> DocIdValidator = new docIDValidator();
      public  SpecialistValidator()
        {
            var fioValidResalt = FIOValidator.Validate(Item.FIO);
            var docIdValidResalt = DocIdValidator.Validate(Item.Identificator.ToString());
            AddRule(doc => !fioValidResalt.Valid, fioValidResalt.Errors.First());
            AddRule(doc => !docIdValidResalt.Valid, docIdValidResalt.Errors.First());

        }
    }
}
