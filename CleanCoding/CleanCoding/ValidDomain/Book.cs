using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain
{
    internal class Book
    {
        internal Book()
        {
        }
        internal Book(string title, string author)
        {
            BookValidator.ValidateForCreation(title, author);

            Title = title;
            Author = author;
        }

        internal string Title { get; set; }
        internal string Author { get; set; }

        internal string Price { get; set; }

        internal void UpdateAndFormatPrice(decimal newPrice, string currencyCultureName)
        {
            var currencyCulture = System.Globalization.CultureInfo.CreateSpecificCulture(currencyCultureName);

            Price = newPrice.ToString("C", currencyCulture);
        }
    }
}
