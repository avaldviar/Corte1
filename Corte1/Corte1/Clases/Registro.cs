using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1.Clases
{
    internal class Registro
    {
        private Persona[] personas;
        private int contador;

        public Registro()
        {
            personas = new Persona[30];  
            contador = 0;
        }

        public void AgregarPersona(Persona persona)
        {
            if (contador < 30)
            {
                personas[contador] = persona;
                contador++;
            }
            else
            {
                MessageBox.Show("No se pueden agregar más personas, el registro está lleno.");
            }
        }

        public Persona[] ObtenerPersonas()
        {
            return personas.Where(p => p != null).ToArray();
        }
    }
}
    

