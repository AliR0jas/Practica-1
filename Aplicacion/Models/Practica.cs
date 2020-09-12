using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion.Models
{
    public class Practica
    {
        public int NumeroUno { get; set; }
        public int NumeroDos { get; set; }
        public int Res()
        {
            return NumeroUno + NumeroDos;
        }
    }
}
