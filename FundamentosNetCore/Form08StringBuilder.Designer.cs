namespace FundamentosNetCore
{
    partial class Form08StringBuilder
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
            txtTexto = new RichTextBox();
            label1 = new Label();
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            lblTiempo = new Label();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(249, 103);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(387, 182);
            txtTexto.TabIndex = 0;
            txtTexto.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 80);
            label1.Name = "label1";
            label1.Size = new Size(192, 20);
            label1.TabIndex = 1;
            label1.Text = "Copie el texto para trabajar";
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(249, 338);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(176, 29);
            btnInvertirString.TabIndex = 2;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(459, 338);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(177, 29);
            btnInvertirStringBuilder.TabIndex = 3;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(249, 306);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(77, 20);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "lblTiempo";
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 450);
            Controls.Add(lblTiempo);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtTexto;
        private Label label1;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
        private Label lblTiempo;
    }
}