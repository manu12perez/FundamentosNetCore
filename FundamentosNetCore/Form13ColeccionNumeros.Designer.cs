﻿namespace FundamentosNetCore
{
    partial class Form13ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            label3 = new Label();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 83);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(142, 106);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(224, 204);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(395, 102);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(218, 29);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(395, 137);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(218, 29);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(395, 192);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(488, 189);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(125, 27);
            txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(488, 232);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(125, 27);
            txtPares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(395, 235);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Pares";
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(488, 283);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(125, 27);
            txtImpares.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(395, 286);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 8;
            label4.Text = "Impares";
            // 
            // Form13ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtImpares);
            Controls.Add(label4);
            Controls.Add(txtPares);
            Controls.Add(label3);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form13ColeccionNumeros";
            Text = "Form13ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lstNumeros;
        internal Label label1;
        private Button btnGenerar;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtPares;
        private Label label3;
        private TextBox txtImpares;
        private Label label4;
    }
}