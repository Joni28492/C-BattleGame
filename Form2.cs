using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANCIENT_WARS
{
    public partial class Form2 : Form
    {
        public int eleccion=1;

        

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBatalla_Click(object sender, EventArgs e)
        {








            Form3 batalla = new Form3(eleccion);
            batalla.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            eleccion = 2;
            btnMaquina.Enabled = false;
            btnHumano.Enabled = true;
            btnBestia.Enabled = true;
                
        }

        private void btnHumano_Click(object sender, EventArgs e)
        {

            eleccion = 1;
            btnMaquina.Enabled = true;
            btnHumano.Enabled = false;
            btnBestia.Enabled = true;
        }

        private void btnBestia_Click(object sender, EventArgs e)
        {



            eleccion = 3;
            btnMaquina.Enabled = true;
            btnHumano.Enabled = true;
            btnBestia.Enabled = false;
        }

        private void pbHumano_MouseHover(object sender, EventArgs e)
        {
            lblDescripcion.Text = "humano";
        }

        private void pbMaquina_MouseHover(object sender, EventArgs e)
        {
            lblDescripcion.Text = "Maquina";
        }

        private void pbGrifo_MouseHover(object sender, EventArgs e)
        {
            lblDescripcion.Text = "Animal";
        }
    }
}
