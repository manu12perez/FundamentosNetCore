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
    public partial class Form19SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        int suma;

        public Form19SumarCheckbox()
        {
            InitializeComponent();

            this.checkboxes = new List<CheckBox>();
            this.suma = 0;

            // ALMACENAMOS TODOS LOS CONTROLES DEL PANEL
            foreach (CheckBox checkbox in this.panel1.Controls)
            {
                this.checkboxes.Add(checkbox);

                // DELEGAMOS LA ACCION DE LOS CHECKBOXES
                checkbox.Click += SumarNumeros;
            }
        }

        void SumarNumeros(object sender, EventArgs e)
        {
            // Capturamos el CheckBox que disparó el evento
            CheckBox checkbox = (CheckBox)sender;
            int numero = int.Parse(checkbox.Text);

            // Si está marcado, sumamos; si no, restamos
            if (checkbox.Checked)
            {
                this.suma += numero;
            }
            else
            {
                this.suma -= numero;
            }

            // Actualizamos el texto en el cuadro de texto
            this.txtSuma.Text = this.suma.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.suma = 0;
            this.txtSuma.Text = suma.ToString();

            // RECORREMOS TODOS LOS CHECKBOXES Y ASIGNAMOS NÚMEROS ALEATORIOS
            foreach (CheckBox checkbox in this.checkboxes)
            {
                int numAleat = random.Next(1, 99);
                checkbox.Text = numAleat.ToString();

                // Reiniciar el estado de los CheckBoxes
                checkbox.Checked = false;
            }
        }
    }
}
