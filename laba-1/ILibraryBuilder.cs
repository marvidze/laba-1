using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    interface ILibraryBuilder
    {
        LibraryBuilder SetName(string name);
        LibraryBuilder SetAddress(string address);
        LibraryBuilder SetNumberOfPhone(string numberOfPhone);
        LibraryBuilder SetRating(float rating);
        LibraryBuilder SetCountOfBooks(int countOfBooks);
        LibraryBuilder SetCountOfSeats(int countOfSeats);
    }
}
