namespace FundamentosNetCore
{
    partial class Form14TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnEliminarTodo = new Button();
            label2 = new Label();
            lstTienda = new ListBox();
            btnSeleccion = new Button();
            btnTodos = new Button();
            lstAlmacen = new ListBox();
            label3 = new Label();
            btnSubir = new Button();
            btnBajar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 86);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 27);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 133);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 29);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(12, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(125, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEliminarTodo
            // 
            btnEliminarTodo.Location = new Point(12, 203);
            btnEliminarTodo.Name = "btnEliminarTodo";
            btnEliminarTodo.Size = new Size(125, 29);
            btnEliminarTodo.TabIndex = 4;
            btnEliminarTodo.Text = "EliminarTodo";
            btnEliminarTodo.UseVisualStyleBackColor = true;
            btnEliminarTodo.Click += btnEliminarTodo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 56);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Tienda";
            // 
            // lstTienda
            // 
            lstTienda.FormattingEnabled = true;
            lstTienda.Location = new Point(159, 86);
            lstTienda.Name = "lstTienda";
            lstTienda.Size = new Size(174, 244);
            lstTienda.TabIndex = 6;
            // 
            // btnSeleccion
            // 
            btnSeleccion.Location = new Point(354, 168);
            btnSeleccion.Name = "btnSeleccion";
            btnSeleccion.Size = new Size(94, 29);
            btnSeleccion.TabIndex = 7;
            btnSeleccion.Text = "Selección";
            btnSeleccion.UseVisualStyleBackColor = true;
            btnSeleccion.Click += btnSeleccion_Click;
            // 
            // btnTodos
            // 
            btnTodos.Location = new Point(354, 203);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(94, 29);
            btnTodos.TabIndex = 8;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // lstAlmacen
            // 
            lstAlmacen.FormattingEnabled = true;
            lstAlmacen.Location = new Point(473, 86);
            lstAlmacen.Name = "lstAlmacen";
            lstAlmacen.Size = new Size(174, 244);
            lstAlmacen.TabIndex = 10;
            lstAlmacen.SelectedIndexChanged += lstAlmacen_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(473, 56);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 9;
            label3.Text = "Almacén";
            // 
            // btnSubir
            // 
            btnSubir.Location = new Point(677, 168);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(94, 29);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // btnBajar
            // 
            btnBajar.Location = new Point(677, 203);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(94, 29);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // Form14TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(lstAlmacen);
            Controls.Add(label3);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccion);
            Controls.Add(lstTienda);
            Controls.Add(label2);
            Controls.Add(btnEliminarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form14TiendaProductos";
            Text = "Form14TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnEliminarTodo;
        private Label label2;
        private ListBox lstTienda;
        private Button btnSeleccion;
        private Button btnTodos;
        private ListBox lstAlmacen;
        private Label label3;
        private Button btnSubir;
        private Button btnBajar;
    }
}