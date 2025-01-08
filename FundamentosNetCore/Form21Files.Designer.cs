namespace FundamentosNetCore
{
    partial class Form21Files
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
            lblContenidoFile = new Label();
            txtContenidoFile = new TextBox();
            lblNombre = new Label();
            btnNuevoNombre = new Button();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            txtNombre = new TextBox();
            lblNombres = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // lblContenidoFile
            // 
            lblContenidoFile.AutoSize = true;
            lblContenidoFile.Location = new Point(157, 51);
            lblContenidoFile.Name = "lblContenidoFile";
            lblContenidoFile.Size = new Size(105, 20);
            lblContenidoFile.TabIndex = 0;
            lblContenidoFile.Text = "Contenido File";
            // 
            // txtContenidoFile
            // 
            txtContenidoFile.Location = new Point(157, 74);
            txtContenidoFile.Multiline = true;
            txtContenidoFile.Name = "txtContenidoFile";
            txtContenidoFile.Size = new Size(255, 235);
            txtContenidoFile.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(467, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(467, 142);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(125, 32);
            btnNuevoNombre.TabIndex = 3;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(467, 215);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(125, 29);
            btnWriteFile.TabIndex = 4;
            btnWriteFile.Text = "Write File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(467, 180);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(125, 29);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(467, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(631, 42);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 7;
            lblNombres.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(631, 66);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(173, 244);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 448);
            Controls.Add(lstNombres);
            Controls.Add(lblNombres);
            Controls.Add(txtNombre);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(btnNuevoNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtContenidoFile);
            Controls.Add(lblContenidoFile);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContenidoFile;
        private TextBox txtContenidoFile;
        private Label lblNombre;
        private Button btnNuevoNombre;
        private Button btnWriteFile;
        private Button btnReadFile;
        private TextBox txtNombre;
        private Label lblNombres;
        private ListBox lstNombres;
    }
}