using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class MainLibrary : Library
    {
        public string name;
        public MainLibrary() : base() { }

        public MainLibrary(string addres, string numberPhone, float rating, int countBooks, int countSeats, ItypeLibrary typeLibrary, string levelLibrary, string name = "Главное здание")
            : base(name, addres, numberPhone, rating, countBooks, countSeats, levelLibrary, typeLibrary) { }
    }
}
