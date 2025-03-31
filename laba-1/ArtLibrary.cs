using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    public class ArtLibrary : ItypeLibrary
    {
        public string type = "Художественная";
        public string GetTypeLibrary()
        {
            return type;
        }
    }
}
