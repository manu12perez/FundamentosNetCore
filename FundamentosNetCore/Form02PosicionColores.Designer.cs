namespace FundamentosNetCore
{
    partial class Form02PosicionColores
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            label2 = new Label();
            txtVerde = new TextBox();
            label3 = new Label();
            txtRojo = new TextBox();
            label4 = new Label();
            txtAzul = new TextBox();
            label5 = new Label();
            btnPosicion = new Button();
            btnColor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Posición X:";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(156, 46);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(125, 27);
            txtPosicionX.TabIndex = 1;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(156, 93);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(125, 27);
            txtPosicionY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Posición Y:";
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(543, 93);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(125, 27);
            txtVerde.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(481, 96);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 6;
            label3.Text = "Verde";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(543, 46);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(125, 27);
            txtRojo.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(481, 49);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 4;
            label4.Text = "Rojo";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(543, 140);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(125, 27);
            txtAzul.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 143);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 8;
            label5.Text = "Azul";
            // 
            // btnPosicion
            // 
            btnPosicion.Location = new Point(105, 167);
            btnPosicion.Name = "btnPosicion";
            btnPosicion.Size = new Size(176, 29);
            btnPosicion.TabIndex = 10;
            btnPosicion.Text = "Cambiar Posición";
            btnPosicion.UseVisualStyleBackColor = true;
            btnPosicion.Click += btnPosicion_Click;
            // 
            // btnColor
            // 
            btnColor.Location = new Point(492, 229);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(176, 29);
            btnColor.TabIndex = 11;
            btnColor.Text = "Cambiar Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // Form02PosicionColores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnColor);
            Controls.Add(btnPosicion);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(txtVerde);
            Controls.Add(label3);
            Controls.Add(txtRojo);
            Controls.Add(label4);
            Controls.Add(txtPosicionY);
            Controls.Add(label2);
            Controls.Add(txtPosicionX);
            Controls.Add(label1);
            Name = "Form02PosicionColores";
            Text = "Form02PosicionColores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Label label2;
        private TextBox txtVerde;
        private Label label3;
        private TextBox txtRojo;
        private Label label4;
        private TextBox txtAzul;
        private Label label5;
        private Button btnPosicion;
        private Button btnColor;
    }
}