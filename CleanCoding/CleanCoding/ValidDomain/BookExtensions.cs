using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCoding.ValidDomain
{
    internal static class BookExtensions
    {
        internal static string GetCover(this Book book)
        {
            return $"{book.Title} {book.Author} {book.Price}";
        }
    }
}
