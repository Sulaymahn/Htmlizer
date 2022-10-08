﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Htmlizer.Engine
{
    public static class MathExtension
    {
        public static int WithinInterval(this int value, int min, int max)
        {
            if (value <= min) return min;
            if(value >= max) return max;
            return value;
        }
    }
}
