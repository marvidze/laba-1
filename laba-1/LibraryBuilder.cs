using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class LibraryBuilder : ILibraryBuilder
    {
        private Library _library = new Library();

        public LibraryBuilder SetName(string name)
        {
            _library.Name = name;
            return this;
        }

        public LibraryBuilder SetAddress(string address)
        {
            _library.Addres = address;
            return this;
        }

        public LibraryBuilder SetNumberOfPhone(string numberOfPhone)
        {
            _library.NumberOfPhone = numberOfPhone;
            return this;
        }

        public LibraryBuilder SetRating(float rating)
        {
            _library.Rating = rating;
            return this;
        }

        public LibraryBuilder SetCountOfBooks(int countOfBooks)
        {
            _library.CountOfBooks = countOfBooks;
            return this;
        }

        public LibraryBuilder SetCountOfSeats(int countOfSeats)
        {
            _library.CountOfSeats = countOfSeats;
            return this;
        }

        public Library Build()
        {
            return _library;
        }
    }
}
