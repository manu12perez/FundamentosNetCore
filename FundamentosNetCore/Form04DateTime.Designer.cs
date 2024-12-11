namespace FundamentosNetCore
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFecha = new CheckBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtIncremento = new TextBox();
            label2 = new Label();
            rbdAños = new RadioButton();
            rbdMeses = new RadioButton();
            rbdDias = new RadioButton();
            label3 = new Label();
            txtFechaNueva = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 57);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(131, 80);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(300, 27);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFecha
            // 
            chkFecha.AutoSize = true;
            chkFecha.Location = new Point(131, 113);
            chkFecha.Name = "chkFecha";
            chkFecha.Size = new Size(185, 24);
            chkFecha.TabIndex = 2;
            chkFecha.Text = "Cambiar formato fecha";
            chkFecha.UseVisualStyleBackColor = true;
            chkFecha.CheckedChanged += chkFecha_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtIncremento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(rbdAños);
            groupBox1.Controls.Add(rbdMeses);
            groupBox1.Controls.Add(rbdDias);
            groupBox1.Location = new Point(131, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 138);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(181, 89);
            button1.Name = "button1";
            button1.Size = new Size(96, 29);
            button1.TabIndex = 5;
            button1.Text = "Incrementar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(169, 56);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(125, 27);
            txtIncremento.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 30);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Incremento";
            // 
            // rbdAños
            // 
            rbdAños.AutoSize = true;
            rbdAños.Location = new Point(16, 86);
            rbdAños.Name = "rbdAños";
            rbdAños.Size = new Size(63, 24);
            rbdAños.TabIndex = 2;
            rbdAños.TabStop = true;
            rbdAños.Text = "Años";
            rbdAños.UseVisualStyleBackColor = true;
            // 
            // rbdMeses
            // 
            rbdMeses.AutoSize = true;
            rbdMeses.Location = new Point(16, 56);
            rbdMeses.Name = "rbdMeses";
            rbdMeses.Size = new Size(71, 24);
            rbdMeses.TabIndex = 1;
            rbdMeses.TabStop = true;
            rbdMeses.Text = "Meses";
            rbdMeses.UseVisualStyleBackColor = true;
            // 
            // rbdDias
            // 
            rbdDias.AutoSize = true;
            rbdDias.Location = new Point(16, 26);
            rbdDias.Name = "rbdDias";
            rbdDias.Size = new Size(59, 24);
            rbdDias.TabIndex = 0;
            rbdDias.TabStop = true;
            rbdDias.Text = "Días";
            rbdDias.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(131, 300);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 4;
            label3.Text = "Nueva fecha";
            // 
            // txtFechaNueva
            // 
            txtFechaNueva.Location = new Point(131, 323);
            txtFechaNueva.Name = "txtFechaNueva";
            txtFechaNueva.Size = new Size(300, 27);
            txtFechaNueva.TabIndex = 5;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 463);
            Controls.Add(txtFechaNueva);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(chkFecha);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFecha;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtIncremento;
        private Label label2;
        private RadioButton rbdAños;
        private RadioButton rbdMeses;
        private RadioButton rbdDias;
        private Label label3;
        private TextBox txtFechaNueva;
    }
}