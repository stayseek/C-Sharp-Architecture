﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_1
{
    interface IFigureFactory
    {
        IDrawAPI GetFigure(string description);
    }
}
