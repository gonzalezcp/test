﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.PIterador;

namespace TP
{
    public interface Coleccionable : Iterable
    {
        int Cunatos();
        void Agregar(Comparable o);
        Comparable Minimo();
        Comparable Maximo();
        bool Contiene(Comparable o);

    }
}
