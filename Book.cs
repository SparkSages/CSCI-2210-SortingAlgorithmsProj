///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Book Class
//
///////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
namespace Books
{
    /// <summary>
    /// Book Class
    /// </summary>
    public class Book : IComparable<Book>
    {
        /// <summary>
        /// Gets or sets the last name of the author.
        /// </summary>
        /// <value>
        /// The last name of the author.
        /// </value>
        public string LastName { get; set; }
        /// <summary>
        /// Gets or sets the first name of the author.
        /// </summary>
        /// <value>
        /// The first name of the author.
        /// </value>
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        /// <value>
        /// The title of the book.
        /// </value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the release date of the book.
        /// </summary>
        /// <value>
        /// The release date of the book.
        /// </value>
        public DateTime ReleaseDate { get; set; }

        public Book(string lastName, string firstName, string title, DateTime releaseDate)
        {
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            ReleaseDate = releaseDate;
        }

        /// <summary>
        /// Parse a string in the format "LastName, FirstName, Title, ReleaseDate" into a Book object
        /// </summary>
        /// <param name="str">The string to parse</param>
        /// <returns>a <see cref="Book"/></returns>
        public static Book Parse(string str)
        {
            // Split the input string into parts assuming a specific format
            string[] parts = str.Split('|');
            if (parts.Length != 6)
            {
                throw new FormatException("Invalid format for parsing a book.");
            }

            string lastName = parts[1].Trim();
            string firstName = parts[2].Trim();
            string title = parts[3].Trim();
            if (!DateTime.TryParse(parts[4].Trim(), out DateTime releaseDate))
            {
                throw new FormatException("Invalid release date format.");
            }

            return new Book(lastName, firstName, title, releaseDate);
        }

        /// <summary>
        /// Tries to parse the specified string into a book.
        /// </summary>
        /// <param name="str">The string to parse</param>
        /// <param name="book">The book</param>
        /// <returns>True if the string was parsed successfully, false otherwise</returns>
        public static bool TryParse(string str, out Book? book)
        {
            try
            {
                book = Parse(str);
                return true;
            }
            catch (FormatException)
            {
                book = null;
                return false;
            }
        }

        /// <summary>
        /// Compares this book to another book.
        /// </summary>
        /// <param name="other">The <see cref="Book"/> to compare</param>
        public int CompareTo(Book? other)
        {
            if (other is null)
            {
                return 1;
            }

            // Compare by last name
            int lastNameComparison = string.Compare(this.LastName, other.LastName, StringComparison.Ordinal);
            if (lastNameComparison != 0)
            {
                return lastNameComparison;
            }

            //  Then, compare by first name
            int firstNameComparison = string.Compare(this.FirstName, other.FirstName, StringComparison.Ordinal);
            if (firstNameComparison != 0)
            {
                return firstNameComparison;
            }

            // Then, compare by title
            int titleComparison = string.Compare(this.Title, other.Title, StringComparison.Ordinal);
            if (titleComparison != 0)
            {
                return titleComparison;
            }

            //I have no idea what StringComparison.Ordinal does, but it works

            //Else, compare by release date
            return this.ReleaseDate.CompareTo(other.ReleaseDate);
        }

        /// <summary>
        /// Returns a string representation of this book.
        /// </summary>
        public override string ToString()
        {
            return $"{LastName}, {FirstName}: {Title} ({ReleaseDate.Year})";
        }
    }
}