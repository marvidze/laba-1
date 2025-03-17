using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba_1
{
    public class LibraryDirector
    {
        private ILibraryBuilder _builder;

        public void SetBuilder(ILibraryBuilder builder)
        {
            _builder = builder;
        }

        public Library ConstructLibrary(string Name, string Adress, string Tel, float Rating, int Books, int Place)
        {
            return _builder.SetName(Name)
                .SetAddress(Adress)
                .SetNumberOfPhone(Tel)
                .SetRating(Rating)
                .SetCountOfBooks(Books)
                .SetCountOfSeats(Place)
                .Build();
        }
    }
}
