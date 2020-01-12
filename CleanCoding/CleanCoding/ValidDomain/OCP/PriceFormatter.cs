using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain.OCP
{
    internal static class PriceFormatter
    {
        internal static string FormatPrice(decimal newPrice, string currencyCultureName)
        {
            PriceValidator.ValidateForUpdate(newPrice, currencyCultureName);

            var currencyCulture = System.Globalization.CultureInfo.CreateSpecificCulture(currencyCultureName);

            return newPrice.ToString("C", currencyCulture);
        }
    }
}
