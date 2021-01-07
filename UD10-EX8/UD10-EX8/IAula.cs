using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX8
{
    public interface IAula
    {
        int Id { get; set; }
        int MaxEstudiantes { get; set; }
        Materia Materia { get; set; }
        IEnumerable<IEstudiante> Estudiantes { get; set; }
        IProfesor Profesor { get; set; }

        bool DarClase();
        void EntregarNotas();

    }
}
