﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal interface Vehicle
    {
        public int maxspeed { get; set; }

        public string Start();

        public string Stop();
    }
}
