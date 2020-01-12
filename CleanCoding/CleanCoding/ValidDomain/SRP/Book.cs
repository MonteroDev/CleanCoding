using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain.SRP
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

        internal void UpdatePrice(decimal newPrice, string currencyCultureName)
        {
            Price = PriceFormatter.FormatPrice(newPrice, currencyCultureName);
        }

        internal void UpdateTitle(string newTitle)
        {
            BookValidator.ValidateTitle(newTitle);
            Title = newTitle;
        }

        internal void UpdateAuthor(string newAuthor)
        {
            BookValidator.ValidateAuthor(newAuthor);
            Author = newAuthor;
        }
    }    
}
