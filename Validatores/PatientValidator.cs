using System;
using DataUtilites;
using TehnologyProgramingModels;
using System.Text.RegularExpressions;
using System.Linq;

namespace Validatores
{
    public class PatientValidator : Validator<Patient>
    {
        IValidator<string> fioValidator = new FIOValidator();
        IValidator<string> snilsValidator = new SNILSValidator();
       public PatientValidator()
        {
            var fioValidResalt = fioValidator.Validate(Item.FIO);
            var snilsValidResalt = snilsValidator.Validate(Item.SNILS);
            AddRule(pat => !fioValidResalt.Valid, fioValidResalt.Errors.First());
            AddRule(pat => !snilsValidResalt.Valid, snilsValidResalt.Errors.First());

        }
    }
}
