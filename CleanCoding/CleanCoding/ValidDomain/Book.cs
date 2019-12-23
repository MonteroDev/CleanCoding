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

        internal string Title { get; private set; }
        internal string Author { get; private set; }

        internal string Price { get; private set; }

        public void UpdatePrice(decimal newPrice, string currencyCultureName)
        {
            Price = PriceFormatter.FormatPrice(newPrice, currencyCultureName);
        }
    }
}
