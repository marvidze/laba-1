﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_1
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
