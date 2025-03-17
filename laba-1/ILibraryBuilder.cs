using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public interface ILibraryBuilder
    {
        ILibraryBuilder SetName(string name);
        ILibraryBuilder SetAddress(string address);
        ILibraryBuilder SetNumberOfPhone(string numberOfPhone);
        ILibraryBuilder SetRating(float rating);
        ILibraryBuilder SetCountOfBooks(int countOfBooks);
        ILibraryBuilder SetCountOfSeats(int countOfSeats);
        ILibraryBuilder SetTypeOfLibrary();
        Library Build();
    }
}
