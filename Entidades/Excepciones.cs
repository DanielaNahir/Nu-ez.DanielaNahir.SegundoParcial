using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EspacioInternacionException : Exception
    {
        public EspacioInternacionException()
            : base("No hay espacio disponible")
        {
        }
    }

}