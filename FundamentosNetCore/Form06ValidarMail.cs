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
    public partial class Form06ValidarMail : Form
    {
        public Form06ValidarMail()
        {
            InitializeComponent();
        }

        //private void btnValidar_Click(object sender, EventArgs e)
        //{
        //    string email = txtEmail.Text.Trim();
        //    lblResultado.Text = ""; // Limpiar el resultado previo

        //    // Validar que exista al menos un '@'
        //    if (!email.Contains("@"))
        //    {
        //        lblResultado.Text = "El email debe contener un '@'.";
        //    }
        //    // Validar que '@' no esté al inicio ni al final
        //    else if (email.IndexOf("@") == 0 || email.LastIndexOf("@") == email.Length - 1)
        //    {
        //        lblResultado.Text = "El '@' no puede estar al inicio ni al final.";
        //    }
        //    // Validar que no exista más de un '@'
        //    else if (email.IndexOf("@") != email.LastIndexOf("@"))
        //    {
        //        lblResultado.Text = "El email no puede contener más de un '@'.";
        //    }
        //    // Validar que exista un punto
        //    else if (!email.Contains("."))
        //    {
        //        lblResultado.Text = "El email debe contener al menos un punto.";
        //    }
        //    // Validar que exista un punto después del '@'
        //    else if (email.IndexOf(".", email.IndexOf("@")) == -1)
        //    {
        //        lblResultado.Text = "Debe haber un punto después del '@'.";
        //    }
        //    // Validar el dominio (después del último punto)
        //    else
        //    {
        //        string dominio = email.Substring(email.LastIndexOf(".") + 1);
        //        if (dominio.Length < 2 || dominio.Length > 4)
        //        {
        //            lblResultado.Text = "El dominio debe tener entre 2 y 4 caracteres.";
        //        }
        //        else
        //        {
        //            lblResultado.Text = "El email es válido.";
        //        }
        //    }
        //}
        private void btnValidarMail_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            if (email.Contains("@") == false)
            {
                this.lblResultado.Text = "No existe @";
            }
            else if (email.IndexOf("@") == 0 || email.EndsWith("@") == true)
            {
                this.lblResultado.Text = "@ al inicio o al final";
            }
            else if (email.IndexOf("@") != email.LastIndexOf("@"))
            {
                this.lblResultado.Text = "Más de una @ en el mail";
            }
            else if (email.IndexOf(".") == -1)
            {
                this.lblResultado.Text = "no existe punto en el mail";
            }
            else if (email.LastIndexOf(".") < email.IndexOf("@"))
            {
                this.lblResultado.Text = "Necesitamos un punto después de @";
            }
            else
            {
                int ultimoPunto = email.LastIndexOf(".");
                string dominio = email.Substring(ultimoPunto + 1);
                if (dominio.Length >= 2 && dominio.Length <= 4)
                {
                    this.lblResultado.Text = "Email correcto";
                }
                else
                {
                    this.lblResultado.Text = "Dominio de 2 a 4 caracteres";
                }
            }
        }

    }
}
