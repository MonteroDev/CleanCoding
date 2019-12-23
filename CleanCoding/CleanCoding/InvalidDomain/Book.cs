using System;

namespace CleanCoding.InvalidDomain
{
    internal class Book
    {
        internal Book()
        {
        }
        internal Book(string title, string author)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException();
            }

            Title = title;
            Author = author;
        }

        internal string Title { get; set; }
        internal string Author { get; set; }

        internal string Price { get; set; }

        internal void UpdateAndFormatPrice(decimal newPrice,string currencyCultureName)
        {
            var currencyCulture = System.Globalization.CultureInfo.CreateSpecificCulture(currencyCultureName);

            Price = newPrice.ToString("C", currencyCulture);
        }        
    }
}
