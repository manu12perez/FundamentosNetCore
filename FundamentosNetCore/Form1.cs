namespace FundamentosNetCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsar_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.textNombre.Location = new Point(20, 10);
            this.textNombre.Text = "Soy un string";
            this.textNombre.Width = 220;
            this.textNombre.TextAlign = HorizontalAlignment.Left;
            this.btnPulsar.BackColor = Color.Blue;

            /**
             * //NO ES CONVERSION AUTOMATICA
             * int mayor = 88;
             * short peque�o = mayor;
            **/

            /**
             * //ES CONVERSION AUTOMATICA
             * short peque�o = 88;
             * int mayor = peque�o;
            **/

            /**
             * //STRING A PRIMITIVO
             * string textoNumero = "123456";
             * int numero = int.Parse(textoNumero);
             * double otro = double.Parse(textoNumero);
            **/
        }
    }
}
