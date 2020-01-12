using System;

namespace CleanCoding.ValidDomain.DIP
{
    internal static class BookValidator
    {
        internal static void ValidateForCreation(string title, string author)
        {
            ValidateTitle(title);
            ValidateAuthor(author);
        }

        internal static void ValidateAuthor(string author)
        {
            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException(nameof(author));
            }
        }

        internal static void ValidateTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
        }
    }
}