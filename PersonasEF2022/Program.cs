using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using PersonasEF2022.Modelos;

namespace PersonasEF2022
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonasDbContext())
            {
                var lista = context.Personas.ToList();
                foreach (var persona in lista)
                {
                    Console.WriteLine($"{persona.Apellido}, {persona.Nombres}");
                }

                Console.WriteLine($"Cantidad de registros: {context.Personas.Count()}");
            }

            Console.ReadLine();
        }
    }
}
