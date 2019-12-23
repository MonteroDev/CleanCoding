using System;

namespace CleanCoding.ValidDomain
{
    internal static class BookValidator
    {
        internal static void ValidateForCreation(string title, string author)
        {
            ValidateTitleForCreation(title);
            ValidateAuthorForCreation(author);
        }

        private static void ValidateAuthorForCreation(string author)
        {
            if (string.IsNullOrEmpty(author))
            {
                throw new ArgumentNullException(nameof(author));
            }
        }

        private static void ValidateTitleForCreation(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException(nameof(title));
            }
        }
    }
}