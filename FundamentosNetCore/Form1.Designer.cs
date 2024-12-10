namespace FundamentosNetCore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPulsar = new Button();
            label1 = new Label();
            textNombre = new TextBox();
            SuspendLayout();
            // 
            // btnPulsar
            // 
            btnPulsar.Location = new Point(265, 193);
            btnPulsar.Name = "btnPulsar";
            btnPulsar.Size = new Size(204, 37);
            btnPulsar.TabIndex = 0;
            btnPulsar.Text = "Pulsar";
            btnPulsar.UseVisualStyleBackColor = true;
            btnPulsar.Click += btnPulsar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 75);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 1;
            label1.Text = "Introduzca un nombre";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(265, 98);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(204, 27);
            textNombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textNombre);
            Controls.Add(label1);
            Controls.Add(btnPulsar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPulsar;
        private Label label1;
        private TextBox textNombre;
    }
}
