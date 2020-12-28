using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataUtilites
{
    public interface IValidator<T>
    {
        (bool Valid, IEnumerable<string> Errors) Validate(T obj);
    }

    public abstract class Validator<T> : IValidator<T>
    {
        protected T Item;
        public (bool Valid, IEnumerable<string> Errors) Validate(T obj)
        {
            var errors = Rules.Select(x => x.Check(obj)).Where(x => !x.Valid).ToList();
            return (errors.Any(), errors.Select(x => x.Error));
        }

        private List<ValidationRule<T>> Rules = new List<ValidationRule<T>>();

        private void AddRule(ValidationRule<T> rule)
        {
            this.Rules.Add(rule);
        }
        public void AddRule(Func<T, bool> rule, string error)
        {
            this.Rules.Add(new ValidationRule<T>(rule, error));
        }
    }

    public class ValidationRule<T>
    {
        public ValidationRule(Func<T, bool> rule, string error)
        {
            this.Rule = rule;
            this.Message = error;
        }
        public (bool Valid, string Error) Check(T item) => Rule(item) ? (true, "") : (false, Message);
        public Func<T, bool> Rule { get; set; }
        public string Message { get; set; }
    }
}
