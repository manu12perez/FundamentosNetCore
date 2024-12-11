namespace FundamentosNetCore
{
    partial class Form03DiaNacimiento
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
            txtDia = new TextBox();
            txtMes = new TextBox();
            label2 = new Label();
            txtAño = new TextBox();
            label3 = new Label();
            btnCalcularDia = new Button();
            lblDiaSemana = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(132, 57);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(132, 80);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(125, 27);
            txtDia.TabIndex = 1;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(132, 154);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(125, 27);
            txtMes.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 131);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Mes";
            // 
            // txtAño
            // 
            txtAño.Location = new Point(132, 233);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(125, 27);
            txtAño.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 210);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 4;
            label3.Text = "Año";
            // 
            // btnCalcularDia
            // 
            btnCalcularDia.Location = new Point(444, 57);
            btnCalcularDia.Name = "btnCalcularDia";
            btnCalcularDia.Size = new Size(149, 117);
            btnCalcularDia.TabIndex = 6;
            btnCalcularDia.Text = "Calcular Día Nacimiento";
            btnCalcularDia.UseVisualStyleBackColor = true;
            btnCalcularDia.Click += btnCalcularDia_Click;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Location = new Point(461, 233);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(102, 20);
            lblDiaSemana.TabIndex = 7;
            lblDiaSemana.Text = "lblDiaSemana";
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDiaSemana);
            Controls.Add(btnCalcularDia);
            Controls.Add(txtAño);
            Controls.Add(label3);
            Controls.Add(txtMes);
            Controls.Add(label2);
            Controls.Add(txtDia);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDia;
        private TextBox txtMes;
        private Label label2;
        private TextBox txtAño;
        private Label label3;
        private Button btnCalcularDia;
        private Label lblDiaSemana;
    }
}