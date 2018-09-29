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
    public partial class Form3 : Form
    {

        private Personaje jugador;
        //public Form2 f;
        int eleccion;

        public Form3(int eleccion)
        {
            InitializeComponent();
            this.eleccion = eleccion;
        }



        private void Form3_Load(object sender, EventArgs e)
        {


         

            if (eleccion == 1)
                jugador = new Humano("humano", 250, 10, 160, 120, 6, "", 6, false, 2);
            else if (eleccion == 2)
                jugador = new Maquina("maquina", 400, 15, 250, 180, 2, "", 160, 2, 20, 4);
            else
                jugador = new Animal("animal", 300, 12, 210, 190, 10, "", 50, 10, true);


            if (jugador is Animal)
            {

                pbJugador.BackgroundImage = Properties.Resources.grifo1;
                btnEspecialUno.Text = "Envenenar";
                btnEspecialDos.Text = "Aplastar";
                btnEspecialTres.Text = "Romper Armadura";

            }

            else if(jugador is Maquina)
            {

                pbJugador.BackgroundImage = Properties.Resources.maquina;
                btnEspecialUno.Text = "Añadir Strike";
                btnEspecialDos.Text = "Desanimar";
                btnEspecialTres.Text = "Repararse";

            }

            else
            {
                pbJugador.BackgroundImage = Properties.Resources.humano;
                btnEspecialUno.Text = "Paralizar";
                btnEspecialDos.Text = "Motivacion";
                btnEspecialTres.Text = "Trampa";

            }





        }

        //ataque normal 
        private void btnAtaqueNormal_Click(object sender, EventArgs e)
        {
            //jugador.ataque();
        }

        //cubrirse
        private void btnCubrirse_Click(object sender, EventArgs e)
        {

        }

        //recuperarse
        private void btnRecuperarse_Click(object sender, EventArgs e)
        {

        }


        //ataque especial 1
        private void btnEspacialUno_Click(object sender, EventArgs e)
        {

        }
        //atqque especial 2
        private void btnEspecialDos_Click(object sender, EventArgs e)
        {

        }
        //ataque especial 3
        private void btnEspecialTres_Click(object sender, EventArgs e)
        {
            
        }
    }
}
