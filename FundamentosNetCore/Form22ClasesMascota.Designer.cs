namespace FundamentosNetCore
{
    partial class Form22ClasesMascota
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            lblRaza = new Label();
            btnNuevaMascota = new Button();
            lblMascota = new Label();
            lstMascotas = new ListBox();
            btnLeerMascota = new Button();
            btnGuardarMascota = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(118, 56);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(118, 133);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(188, 27);
            txtRaza.TabIndex = 3;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(118, 110);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(41, 20);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(118, 221);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(188, 29);
            btnNuevaMascota.TabIndex = 4;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.Location = new Point(370, 56);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(71, 20);
            lblMascota.TabIndex = 5;
            lblMascota.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(370, 79);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(190, 264);
            lstMascotas.TabIndex = 6;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnLeerMascota
            // 
            btnLeerMascota.Location = new Point(118, 256);
            btnLeerMascota.Name = "btnLeerMascota";
            btnLeerMascota.Size = new Size(188, 29);
            btnLeerMascota.TabIndex = 7;
            btnLeerMascota.Text = "Leer Mascota";
            btnLeerMascota.UseVisualStyleBackColor = true;
            btnLeerMascota.Click += btnLeerMascota_Click;
            // 
            // btnGuardarMascota
            // 
            btnGuardarMascota.Location = new Point(118, 291);
            btnGuardarMascota.Name = "btnGuardarMascota";
            btnGuardarMascota.Size = new Size(188, 29);
            btnGuardarMascota.TabIndex = 8;
            btnGuardarMascota.Text = "Guardar Mascota";
            btnGuardarMascota.UseVisualStyleBackColor = true;
            btnGuardarMascota.Click += btnGuardarMascota_Click;
            // 
            // Form22ClasesMascota
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardarMascota);
            Controls.Add(btnLeerMascota);
            Controls.Add(lstMascotas);
            Controls.Add(lblMascota);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(lblRaza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form22ClasesMascota";
            Text = "Form22ClasesMascota";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label lblRaza;
        private Button btnNuevaMascota;
        private Label lblMascota;
        private ListBox lstMascotas;
        private Button btnLeerMascota;
        private Button btnGuardarMascota;
    }
}