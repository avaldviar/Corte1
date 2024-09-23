using Corte1.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro;

        public Form1()
        {
            InitializeComponent();
            registro = new Registro();
            comboBoxCiudad.Items.AddRange(new string[] { "Managua", "Masaya", "Carazo", "Diriamba", "Matagalpa", "San Juan del Sur", "Chinandega", "Rivas", "Boaco", "Leon", "Chontales", "RAAN", "RAAS", "Jinotega", "Esteli", "Madrid", "Granada" });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (registro.ObtenerPersonas().Length > 0)
            {
                Persona ultimaPersona = registro.ObtenerPersonas().Last();
                int edad = Operacion.CalcularEdad(ultimaPersona);
                bool mayorDeEdad = Operacion.EsMayorDeEdad(ultimaPersona);

                string mensaje = $"La persona tiene {edad} años y es {(mayorDeEdad ? "mayor" : "menor")} de edad.";
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No hay personas registradas.");
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombres = textBoxNombres.Text;
            string apellidos = textBoxApellidos.Text;
            DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;
            string ciudad = comboBoxCiudad.SelectedItem.ToString();

            Persona persona = new Persona(nombres, apellidos, fechaNacimiento, ciudad);
            registro.AgregarPersona(persona);

            MessageBox.Show("Persona agregada correctamente.");
        }
    }
}
