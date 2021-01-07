using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX8
{
    public class Profesor : IProfesor
    {
        public Materia Materia { get; set; }
        public string Nombre { get; set; } = "Profesor";
        public int Edad { get; set; }
        public Genero Genero { get; set; }
        public bool Disponible { get; set; }

        public Profesor()
        {
            Random rd = new Random();
            Materia = rd.NextEnum<Materia>();
            Edad = rd.Next(25, 65);
            Genero = rd.NextEnum<Genero>();
            Disponible = rd.Next(0, 5) != 2;
        }
    }
}
