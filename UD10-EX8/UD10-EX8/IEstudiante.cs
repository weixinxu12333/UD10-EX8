using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX8
{
    public interface IEstudiante : IPersona
    {
        double Calificacion { get; set; }
    }
}
