using System;

namespace UD10_EX8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Aula a = new Aula(i);
                if (a.DarClase()) a.EntregarNotas();
                else Console.WriteLine($"No se puede dar clase en el aula {i}");
            }
        }
    }
}
