using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_EX8
{
    public class Estudiante : IEstudiante
    {
        public double Calificacion { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Genero Genero { get; set; }
        public bool Disponible { get; set; }

        public Estudiante(int id)
        {
            Random rd = new Random();
            Calificacion = rd.Next(0, 11);
            Nombre = $"Estudiante{id}";
            Edad = rd.Next(13, 17);
            Genero = rd.NextEnum<Genero>();
            Disponible = rd.Next(0, 2) == 1;
        }
    }
}
