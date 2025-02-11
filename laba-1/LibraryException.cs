using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    /// <summary>
    /// Класс исключений для класса Library
    /// </summary>
    internal class LibraryException : Exception
    {
        public LibraryException(string message)
        : base(message)
        { }

    }
}
