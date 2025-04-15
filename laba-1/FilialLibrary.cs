using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    /// <summary>
    /// Класс, представляющий филиал библиотеки, одну из абстракций
    /// </summary>
    public class FilialLibrary : Library
    {
        public FilialLibrary() : base() { }

        public FilialLibrary(string addres, string numberPhone, float rating, int countBooks, int countSeats, ItypeLibrary typeLibrary, string levelLibrary, string name = "Филиал")
            : base(name, addres, numberPhone, rating, countBooks, countSeats, levelLibrary, typeLibrary) { }

    }
}
