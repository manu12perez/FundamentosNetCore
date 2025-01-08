using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace FundamentosNetCore
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Navidad";
            persona.Edad = 28;
            persona.Genero = TipoGenero.Femenino;
            persona.Nacionalidad = Paises.Andorra;


            this.lstClases.Items.Add("Indizada " + persona[0]);

            //persona.Domicilio = new Direccion(); //o se instancia en el form o en la clase
            persona.Domicilio.Calle = "Oficina principal de Correos";
            persona.Domicilio.Ciudad = "Napapiiri, Finlandia";
            persona.Domicilio.CodigoPostal = 96930;
            this.lstClases.Items.Add(
                "Direccion: " + persona.Domicilio.Calle +
                ", " + persona.Domicilio.Ciudad +
                ", " + persona.Domicilio.CodigoPostal);

            this.lstClases.Items.Add("Nombre: " + persona.GetNombreCompleto());
            this.lstClases.Items.Add("Edad: " + persona.Edad);
            this.lstClases.Items.Add("Género: " + persona.Genero + ", Nacionalidad: " + persona.Nacionalidad);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado empleado = new Empleado("Empleado", "Empleado");
            Empleado empleado = new Empleado();
            empleado.Nombre = "Empleado";
            empleado.Apellidos = "Empleado";

            this.lstClases.Items.Add(empleado.GetNombreCompleto());
            this.lstClases.Items.Add("Salario empleado " + empleado.GetSalarioMinimo());
            this.lstClases.Items.Add("Vacaciones empleado " + empleado.GetDiasVacaciones());

            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = " Director";
            this.lstClases.Items.Add(dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario director " + dire.GetSalarioMinimo());
            this.lstClases.Items.Add("Vacaciones director " + dire.GetDiasVacaciones());
        }
    }
}
