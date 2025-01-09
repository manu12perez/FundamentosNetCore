namespace FundamentosNetCore
{
    partial class Form25ColeccionMascotasJSON
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
            txtYears = new TextBox();
            lblYears = new Label();
            btnGuardarMascota = new Button();
            btnLeerMascota = new Button();
            lstMascotas = new ListBox();
            lblMascota = new Label();
            btnNuevaMascota = new Button();
            txtRaza = new TextBox();
            lblRaza = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // txtYears
            // 
            txtYears.Location = new Point(76, 214);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(188, 27);
            txtYears.TabIndex = 30;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Location = new Point(76, 191);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(42, 20);
            lblYears.TabIndex = 29;
            lblYears.Text = "Años";
            // 
            // btnGuardarMascota
            // 
            btnGuardarMascota.Location = new Point(537, 217);
            btnGuardarMascota.Name = "btnGuardarMascota";
            btnGuardarMascota.Size = new Size(188, 52);
            btnGuardarMascota.TabIndex = 28;
            btnGuardarMascota.Text = "Guardar Mascota";
            btnGuardarMascota.UseVisualStyleBackColor = true;
            btnGuardarMascota.Click += btnGuardarMascota_Click;
            // 
            // btnLeerMascota
            // 
            btnLeerMascota.Location = new Point(537, 159);
            btnLeerMascota.Name = "btnLeerMascota";
            btnLeerMascota.Size = new Size(188, 52);
            btnLeerMascota.TabIndex = 27;
            btnLeerMascota.Text = "Leer Mascota";
            btnLeerMascota.UseVisualStyleBackColor = true;
            btnLeerMascota.Click += btnLeerMascota_Click;
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(328, 105);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(190, 264);
            lstMascotas.TabIndex = 26;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // lblMascota
            // 
            lblMascota.AutoSize = true;
            lblMascota.Location = new Point(328, 82);
            lblMascota.Name = "lblMascota";
            lblMascota.Size = new Size(71, 20);
            lblMascota.TabIndex = 25;
            lblMascota.Text = "Mascotas";
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(76, 302);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(188, 49);
            btnNuevaMascota.TabIndex = 24;
            btnNuevaMascota.Text = "Nueva Mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(76, 159);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(188, 27);
            txtRaza.TabIndex = 23;
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Location = new Point(76, 136);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(41, 20);
            lblRaza.TabIndex = 22;
            lblRaza.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(76, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 27);
            txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(76, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 20;
            lblNombre.Text = "Nombre";
            // 
            // Form25ColeccionMascotasJSON
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtYears);
            Controls.Add(lblYears);
            Controls.Add(btnGuardarMascota);
            Controls.Add(btnLeerMascota);
            Controls.Add(lstMascotas);
            Controls.Add(lblMascota);
            Controls.Add(btnNuevaMascota);
            Controls.Add(txtRaza);
            Controls.Add(lblRaza);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form25ColeccionMascotasJSON";
            Text = "Form25ColeccionMascotasJSON";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYears;
        private Label lblYears;
        private Button btnGuardarMascota;
        private Button btnLeerMascota;
        private ListBox lstMascotas;
        private Label lblMascota;
        private Button btnNuevaMascota;
        private TextBox txtRaza;
        private Label lblRaza;
        private TextBox txtNombre;
        private Label lblNombre;
    }
}