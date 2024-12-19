using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentosNetCore
{
    public partial class Form14TiendaProductos : Form
    {
        public Form14TiendaProductos()
        {
            InitializeComponent();
            // Configuramos la selección múltiple en la lista de Tienda
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //string producto = this.txtProducto.Text.ToUpper();

            //if (producto == "")
            //{
            //    MessageBox.Show("Debe introducir un producto.");
            //    return;
            //}

            //// Verificar si el producto ya existe en la lista Tienda
            //if (this.lstTienda.Items.Contains(producto))
            //{
            //    MessageBox.Show("El producto ya existe en la Tienda.");
            //    return;
            //}

            //// Añadir el producto a la lista
            //this.lstTienda.Items.Add(producto);
            //this.txtProducto.Clear();
            //this.txtProducto.Focus();

            //FORMA PROFESOR

            string producto = this.txtProducto.Text.ToUpper();
            int index = this.lstTienda.Items.IndexOf(producto);
            if (index == -1)
            {
                this.lstTienda.Items.Add(producto);
                this.txtProducto.SelectAll();
                this.txtProducto.Focus();
            }
            else
            {
                this.lstTienda.SelectedIndex = index;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numSeleccionados = this.lstTienda.SelectedIndices.Count;
            for (int i = numSeleccionados - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            //foreach (var item in this.lstTienda.SelectedItems.Cast<string>().ToList())
            //{
            //    this.lstAlmacen.Items.Add(item);
            //    this.lstTienda.Items.Remove(item);
            //}

            //FORMA PROFESOR

            //ELIMINAMOS DE LA TIENDA LOS SELECCIONADOS
            int numElementos = this.lstTienda.SelectedIndices.Count;
            for (int i = numElementos - 1; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                string producto = this.lstTienda.SelectedItems[i].ToString();
                this.lstAlmacen.Items.Add(producto);
                this.lstTienda.Items.RemoveAt(index);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //foreach (var item in this.lstTienda.Items)
            //{
            //    this.lstAlmacen.Items.Add(item);
            //}
            //this.lstTienda.Items.Clear();

            //FORMA PROFESOR

            //TENEMOS UN METODO LLAMADO AddRange EN LAS COLECCIONES
            //QUE PERMITEN AGREGAR UN CONJUNTO A LA VEZ
            this.lstAlmacen.Items.AddRange(this.lstTienda.Items);
            this.lstTienda.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            if (this.lstAlmacen.SelectedIndex > 0)
            {
                //int index = this.lstAlmacen.SelectedIndex;
                //var item = this.lstAlmacen.Items[index];

                //this.lstAlmacen.Items.RemoveAt(index);
                //this.lstAlmacen.Items.Insert(index - 1, item);
                //this.lstAlmacen.SelectedIndex = index - 1;

                //FORMA PROFESOR
                int index = this.lstAlmacen.SelectedIndex;
                string producto = this.lstAlmacen.SelectedItem.ToString();
                this.lstAlmacen.Items.RemoveAt(index);
                this.lstAlmacen.Items.Insert(index - 1, producto);
                this.lstAlmacen.SelectedIndex = index - 1;
            }
        }

        private void btnBajar_Click(object sender, EventArgs e)
        {
            //if (this.lstAlmacen.SelectedIndex >= 0 && this.lstAlmacen.SelectedIndex < this.lstAlmacen.Items.Count - 1)
            //{
            //    int index = this.lstAlmacen.SelectedIndex;
            //    var item = this.lstAlmacen.Items[index];

            //    this.lstAlmacen.Items.RemoveAt(index);
            //    this.lstAlmacen.Items.Insert(index + 1, item);
            //    this.lstAlmacen.SelectedIndex = index + 1;
            //}

            //FORMA PROFESOR
            int index = this.lstAlmacen.SelectedIndex;
            string producto = this.lstAlmacen.SelectedItem.ToString();
            this.lstAlmacen.Items.RemoveAt(index);
            this.lstAlmacen.Items.Insert(index + 1, producto);
            this.lstAlmacen.SelectedIndex = index + 1;
        }

        private void lstAlmacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstAlmacen.SelectedIndex;
            if (index == 0)
            {
                this.btnSubir.Enabled = false;
            }
            else
            {
                this.btnSubir.Enabled = true;
            }
            if (index == this.lstAlmacen.Items.Count - 1)
            {
                this.btnBajar.Enabled = false;
            }
            else
            {
                this.btnBajar.Enabled = true;
            }
        }
    }
}
