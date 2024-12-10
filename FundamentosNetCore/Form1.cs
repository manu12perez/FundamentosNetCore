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
            this.btnPulsar.BackColor = Color.LightGreen;
        }
    }
}
