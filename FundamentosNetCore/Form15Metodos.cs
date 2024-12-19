﻿using System;
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
    public partial class Form15Metodos : Form
    {
        public Form15Metodos()
        {
            InitializeComponent();
        }

        void GetDobleValor(int num)
        {
            num = num * 2;
        }

        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightBlue;
        }

        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        int GetDoble(int num)
        {
            return num * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            this.GetDobleValor(numero);
            this.lblResultado.Text = numero.ToString();
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            //this.GetDobleReferencia(ref numero);
            numero = this.GetDoble(numero);
            this.lblResultado.Text = numero.ToString();
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        private void Form15Metodos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X: " + e.X + ", Y: " + e.Y;
        }


        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //COMO NO PODEMOS ELIMINAR, DEBEMOS TAMBIEN ADMITIR
            //LA TECLA DE BORRAR (TENEMOS UN CHAR), DEBEMOS SABER
            //QUE TECLA TRADUCIDA CHAR CORRESPONDE CON LA DE BORRAR
            //EXISTE UNA ENUMERACION LLAMADA Keys QUE NOS OFRECE LOS
            //CODIGOS ASCII DE TODSA LAS TECLAS
            char teclaBorrar = (char)Keys.Back;

            if (char.IsDigit(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;

            if (char.IsLetter(e.KeyChar) == false
                && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}


