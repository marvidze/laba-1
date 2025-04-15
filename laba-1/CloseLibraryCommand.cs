using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal class CloseLibraryCommand : ICommand
    {
        private Library library;

        public CloseLibraryCommand(Library library) => this.library = library;

        public void Execute() => library.CloseLibrary();
        public void Undo() => library.OpenLibrary();
    }
}
