using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    /// <summary>
    /// TechnicalLibrary - представляет собой одну из конкретных реализаций (техническая библиотека)
    /// </summary>
    public class TechnicalLibrary : ItypeLibrary
    {
        public string type = "Техническая";
        public string GetTypeLibrary()
        {
            return type;
        }
    }
}
