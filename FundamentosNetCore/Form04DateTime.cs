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
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            //AL INICIAR LA CLASE (CONSTRUCTOR)
            //ESCRIBIREMOS LA FECHA ACTUAL
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void chkFecha_CheckedChanged(object sender, EventArgs e)
        {
            //RECUPERAMOS LA FECHCA DE LA CAJA
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFecha.Checked == true)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            
            if(rbdDias.Checked == true)
            {
                fecha = fecha.AddDays(incremento);
            }
            else if(this.rbdMeses.Checked == true) {
                fecha = fecha.AddMonths(incremento);
            }
            else
            {
                fecha = fecha.AddYears(incremento);
            }
            this.txtFechaNueva.Text = fecha.ToString();
        }
    }
}
