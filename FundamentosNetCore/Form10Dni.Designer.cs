namespace FundamentosNetCore
{
    partial class Form10Dni
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
            txtDni = new TextBox();
            btnValidar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(179, 59);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "Introduzca DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(179, 82);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(419, 27);
            txtDni.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(323, 126);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(94, 29);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar DNI";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 176);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Form10Dni
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnValidar);
            Controls.Add(txtDni);
            Controls.Add(label1);
            Name = "Form10Dni";
            Text = "Form10Dni";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDni;
        private Button btnValidar;
        private Label label2;
    }
}