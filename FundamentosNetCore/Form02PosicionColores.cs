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
    public partial class Form02PosicionColores : Form
    {
        public Form02PosicionColores()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(this.txtPosicionX.Text);
            int posY = int.Parse(this.txtPosicionY.Text);

            this.Left = posX;
            this.Top = posY;

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            // Validar rango de colores (0-255)
            if (rojo < 0 || rojo > 255 || verde < 0 || verde > 255 || azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor debe estar entre 0 y 255", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                return;
            }

            this.BackColor = Color.FromArgb(rojo, verde, azul);
        }
    }
}
