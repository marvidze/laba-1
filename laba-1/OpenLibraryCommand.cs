using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class OpenLibraryCommand : ICommand
    {
        private Library library;
        public OpenLibraryCommand(Library library) 
        {
            this.library = library;
        }

        public void Execute() => library.OpenLibrary();
        public void Undo() => library.CloseLibrary();
    }
}
