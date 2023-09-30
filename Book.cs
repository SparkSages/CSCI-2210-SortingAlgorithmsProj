#region  FileHeader
///////////////////////////////////////////////////////////////////////////////
//
// Authors: Brendan Dalhover - dalhover@etsu.edu
//          Deep Desai - desaid@etsu.edu
// Course: CSCI-2210-001 - Data Structures
// Assignment: Project 2 - Sorting Algorithms
// Description: Book Class
//
///////////////////////////////////////////////////////////////////////////////
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
namespace Books
{
    public class Book : IComparable<Book>
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }

        public Book(string lastName, string firstName, string title, DateTime releaseDate)
        {
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            ReleaseDate = releaseDate;
        }

        public static Book Parse(string str)
        // Parse a string in the format "LastName, FirstName, Title, ReleaseDate" into a Book object
        {
            // Split the input string into parts assuming a specific format
            string[] parts = str.Split(',');
            if (parts.Length != 4)
            {
                throw new FormatException("Invalid format for parsing a book.");
            }

            string lastName = parts[0].Trim();
            string firstName = parts[1].Trim();
            string title = parts[2].Trim();
            if (!DateTime.TryParse(parts[3].Trim(), out DateTime releaseDate))
            {
                throw new FormatException("Invalid release date format.");
            }

            return new Book(lastName, firstName, title, releaseDate);
        }

        public static bool TryParse(string str, out Book book)
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

        public int CompareTo(Book other)
        {

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

        public override string ToString()
        {
            return $"{LastName}, {FirstName}: {Title} ({ReleaseDate.Year})";
        }
    }
}