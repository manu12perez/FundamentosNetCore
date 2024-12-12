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
    public partial class Form10Dni : Form
    {
        public Form10Dni()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            // Cadena de caracteres que contiene las letras correspondientes al DNI
            const string TablaLetras = "TRWAGMYFPDXBNJZSQVHLCKE";

            string dni = txtDni.Text.Trim().ToUpper(); // Limpiar espacios y convertir a mayúscula
            if (dni.Length < 9 || !char.IsLetter(dni[^1]))
            {
                MessageBox.Show("El DNI debe tener 8 números y una letra final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Separar números y letra
            string numeros = dni.Substring(0, dni.Length - 1);
            char letraIngresada = dni[^1];

            if (!int.TryParse(numeros, out int numeroDni))
            {
                MessageBox.Show("Los primeros 8 caracteres deben ser números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular la letra correspondiente
            int indice = numeroDni % 23;
            char letraCalculada = TablaLetras[indice];

            // Validar la letra
            if (letraCalculada == letraIngresada)
            {
                label2.Text = "Correcto, la letra es válida.";
                label2.ForeColor = Color.Green;
            }
            else
            {
                label2.Text = $"Incorrecto, la letra es {letraCalculada}.";
                label2.ForeColor = Color.Red;
            }
        }
    }
}

