using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UD10_EX8
{
    public class Aula : IAula
    {
        public int Id { get; set; }
        public int MaxEstudiantes { get; set; }
        public Materia Materia { get; set; }
        public IEnumerable<IEstudiante> Estudiantes { get; set; }
        public IProfesor Profesor { get; set; }

        public Aula(int id)
        {
            Random rd = new Random();
            Id = id;
            MaxEstudiantes = rd.Next(20, 40);
            Materia = rd.NextEnum<Materia>();
            List<IEstudiante> estudiantes = new List<IEstudiante>();
            for (int i = 0; i < MaxEstudiantes; i++)
            {
                estudiantes.Add(new Estudiante(i));
            }
            Estudiantes = estudiantes;
            Profesor = new Profesor();
        }

        public bool DarClase()
        {
            return Profesor.Disponible
                && Profesor.Materia == Materia
                && Estudiantes.Count(x => x.Disponible) > (Estudiantes.Count() / 2);
        }

        public void EntregarNotas()
        {
            Console.WriteLine("Estudiantes aprobados por género:");
            foreach(var g in Estudiantes.Where(x => x.Calificacion >= 5).GroupBy(x => x.Genero))
            {
                Console.WriteLine($"{g.Key}: {g.Count()}");
            }
        }
    }
}
