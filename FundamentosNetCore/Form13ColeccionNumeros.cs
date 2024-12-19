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
    public partial class Form13ColeccionNumeros : Form
    {
        public Form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            lstNumeros.Items.Clear(); // Limpiar la lista antes de generar nuevos números

            // Limpiar los TextBox
            txtSuma.Clear();
            txtPares.Clear();
            txtImpares.Clear();

            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 101); // Números aleatorios entre 1 y 10
                lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;

            foreach (var item in lstNumeros.Items)
            {
                int numero = Convert.ToInt32(item);
                sumaTotal += numero;

                if (numero % 2 == 0)
                {
                    sumaPares += numero; // Número par
                }
                else
                {
                    sumaImpares += numero; // Número impar
                }
            }

            // Mostrar resultados en los TextBox
            txtSuma.Text = sumaTotal.ToString();
            txtPares.Text = sumaPares.ToString();
            txtImpares.Text = sumaImpares.ToString();
        }
    }
}
