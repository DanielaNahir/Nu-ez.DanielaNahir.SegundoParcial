﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IParsearEnumerados
    {
        ERazaPerro ParsearRazaPerro();

        ERazaGato ParsearRazaGato();

        EExotico ParsearExotico();

        EAlimento ParsearAlimentacion();
    }
}
