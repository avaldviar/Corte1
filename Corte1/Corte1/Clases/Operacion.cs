using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1.Clases
{
    internal class Operacion
    {
        public static int CalcularEdad(Persona persona)
        {
            DateTime hoy = DateTime.Today;
            int edad = hoy.Year - persona.FechaNacimiento.Year;

            if (persona.FechaNacimiento > hoy.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        public static bool EsMayorDeEdad(Persona persona)
        {
            return CalcularEdad(persona) >= 18;
        }
    }
}