﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.PAdapter
{
    //Adaptee
    public interface IImage
    {
        string GetName();
        void ShowPreview();
    }
}
