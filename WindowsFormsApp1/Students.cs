﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Students
    {
        public string FullName { get; set; }
        public override string ToString()
        {
            return $"{FullName}";
        }
    }
}
