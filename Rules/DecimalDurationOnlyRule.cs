using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Practice2.Rules
{
    public class DecimalDurationOnlyRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            decimal port = 0;
            try
            {
                port = decimal.Parse((string)value);
            }
            catch (Exception ex)
            {
                return new ValidationResult(false, $"Invalid characters or {ex.Message}");
                throw;
            }
            if (port < 0 || port >= decimal.MaxValue) return new ValidationResult(false, "Value cannot be less than zero and greater than max value");
            return new ValidationResult(true, null);
        }
    }
}
