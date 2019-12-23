using System;

namespace CleanCoding.ValidDomain
{
    internal static class PriceValidator
    {
        internal static void ValidateForUpdate(decimal newPrice, string currencyCultureName)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException($"{nameof(newPrice)} cannot be negative");
            }

            if (string.IsNullOrWhiteSpace(currencyCultureName))
            {
                throw new ArgumentNullException(nameof(currencyCultureName));
            }
        }
    }
}