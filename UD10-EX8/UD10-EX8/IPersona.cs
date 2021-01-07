using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX8
{
    public interface IPersona
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        Genero Genero { get; set; }
        bool Disponible { get; set; }
    }
}
