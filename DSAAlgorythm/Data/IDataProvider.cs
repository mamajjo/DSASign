﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAAlgorythm.Data
{
    public interface IDataProvider
    {
        byte[] GetData();
        string GetStringData();
    }
}
