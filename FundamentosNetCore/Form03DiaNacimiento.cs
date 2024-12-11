using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void btnCalcularDia_Click(object sender, EventArgs e)
        {
            // Leer los valores ingresados por el usuario
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int anio = int.Parse(txtAño.Text);

            // Ajustar mes y año si es enero o febrero
            if (mes == 1 || mes == 2)
            {
                mes = mes + 12;
                anio = anio - 1;
            }

            // Paso 1: Multiplicar el mes + 1 por 3 y dividirlo entre 5
            int paso1 = ((mes + 1) * 3) / 5;

            // Paso 2: Dividir el año entre 4
            int paso2 = anio / 4;

            // Paso 3: Dividir el año entre 100
            int paso3 = anio / 100;

            // Paso 4: Dividir el año entre 400
            int paso4 = anio / 400;

            // Paso 5: Calcular el total según la fórmula
            int suma = dia + (2 * mes) + anio + paso1 + paso2 - paso3 + paso4 + 2;

            // Paso 6: Dividir el resultado entre 7
            int paso6 = suma / 7;

            // Paso 7: Obtener el resto de la división
            int resto = suma - (paso6 * 7);

            // Determinar el día de la semana según el resto
            string[] diasSemana = { "Sábado", "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            string diaSemana = diasSemana[resto];

            // Mostrar el resultado
            lblDiaSemana.Text = "El día de la semana es: " + diaSemana;
        }
    }
}
