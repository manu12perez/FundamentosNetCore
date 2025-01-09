using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using ProyectoClases.Models;

namespace FundamentosNetCore
{
    public partial class Form25ColeccionMascotasJSON : Form
    {
        ColeccionMascotas mascotasList;

        public Form25ColeccionMascotasJSON()
        {
            InitializeComponent();
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Years = int.Parse(this.txtYears.Text);

            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtYears.Clear();
        }

        private async void btnGuardarMascota_Click(object sender, EventArgs e)
        {
            string json = JsonSerializer.Serialize(this.mascotasList, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync("mascotasList.json", json);

            MessageBox.Show("Mascotas guardadas en formato JSON.");
            this.lstMascotas.Items.Clear();
            this.mascotasList.Clear();
        }

        private void btnLeerMascota_Click(object sender, EventArgs e)
        {
            if (File.Exists("mascotasList.json"))
            {
                string json = File.ReadAllText("mascotasList.json");
                this.mascotasList = JsonSerializer.Deserialize<ColeccionMascotas>(json) ?? new ColeccionMascotas();

                this.DibujarMascotas();
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de mascotas JSON.");
            }
        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.mascotasList[index];
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtYears.Text = mascota.Years.ToString();
            }
        }
    }
}
