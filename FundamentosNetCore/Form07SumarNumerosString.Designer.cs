namespace FundamentosNetCore
{
    partial class Form07SumarNumerosString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblResultado = new Label();
            btnSuma = new Button();
            txtNumeros = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 69);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Números";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(418, 229);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(92, 20);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "lblResultado";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(418, 160);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(160, 29);
            btnSuma.TabIndex = 2;
            btnSuma.Text = "Sumar Números";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click_1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(418, 92);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(125, 27);
            txtNumeros.TabIndex = 3;
            // 
            // Form07SumarNumerosString
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNumeros);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form07SumarNumerosString";
            Text = "Form07SumarNumerosString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private Button btnSuma;
        private TextBox txtNumeros;
    }
}