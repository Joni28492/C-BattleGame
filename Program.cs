using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANCIENT_WARS
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuPrincipal());
        }
    }





    abstract class Personaje
    {
        private double armadura;
        private int strikeArmadura;
        private double intimidacion;
        private int piezas;
        private int tamaño;
        private int garras;
        private bool veneno;
        private double Valor;

        public string Nombre { get; set; }
        public double Vida { get; set; }
        public int Nivel { get; set; }
        public double Ataque{ get; set; }
        public double  Defensa { get; set; }
        public double Velocidad{ get; set; }
        public string Estado { get; set; }


        //constructor

        public Personaje(string nombre, double vida, int nivel, double ataque, double defensa, double velocidad, string estado)
        {

            Nombre = nombre;
            Vida = vida;
            Nivel = nivel;
            Ataque = ataque;
            Defensa = defensa;
            Velocidad = velocidad;
            Estado = estado;

        }//fin del constructor

        public Personaje(double armadura, int strikeArmadura, double intimidacion, int piezas)
        {
            this.armadura = armadura;
            this.strikeArmadura = strikeArmadura;
            this.intimidacion = intimidacion;
            this.piezas = piezas;
        }

        public Personaje(int tamaño, int garras, bool veneno)
        {
            this.tamaño = tamaño;
            this.garras = garras;
            this.veneno = veneno;
        }

        //metodos 
        //ataque normal
        private void ataque (Personaje jugador, Personaje enemigo)
        {

            if (enemigo.Defensa >= 1000)
            {
                ;
            }


           else if (enemigo is Maquina)
            {

                if (enemigo.strikeArmadura > 0)
                    enemigo.strikeArmadura--;
                else
                    enemigo.Vida -= this.Ataque * (this.Nivel / 100)-Defensa/5;

            }


            else {
                enemigo.Vida -= this.Ataque * (this.Nivel / 100)-Defensa/5;

                if (jugador is Humano)
                {
                    enemigo.Vida -= jugador.Valor * 2;
                }

                else if (jugador is Animal)
                {
                    enemigo.Vida -= enemigo.garras * 3;

                }

            }

      

        }
        
        
         
        //cubrirse
        private void cubrirse()
        {
            this.Defensa = 1000;

        }

        //recuperarse
        private void recuperarse()
        {
            this.Vida += 30;
        }




    }//fin de la clase



    //clase humano
    class Humano : Personaje
    {
        public double Valor { get; set; }
        public bool Paraliza { get; set; }
        public int Trampa { get; set; }


        //constructor
        public Humano (string nombre, double vida, int nivel, double ataque, double defensa, double velocidad, string estado, double valor, bool paraliza, int trampa)
            :base(nombre, vida, nivel, ataque, defensa, velocidad, estado)
        {
            Valor = valor;
            Paraliza = paraliza;
            Trampa = trampa;
        }

        public static implicit operator Humano(Maquina v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator Humano(Animal v)
        {
            throw new NotImplementedException();
        }

        //metodos
 

        //paralizar()
        private void paralizar(Personaje enemigo)
        {

            enemigo.Estado = "paralizado";


        }


        //motivacion()
        private void motivacion()
        {

            this.Valor += 5;

        }


        //ponerTrampa()
        private void ponerTrampa()
        {

            this.Estado = "trampa";

        }




    }//finde la clase



    //clase maquina 
    class Maquina : Personaje
    {

        public double Armadura { get; set; }
        public int StrikeArmadura { get; set; }
        public double Intimidacion { get; set; }
        public int Piezas { get; set; }




        //constructor 
        public Maquina(string nombre, double vida, int nivel, double ataque, double defensa, double velocidad, string estado,double armadura, int strikeArmadura, double intimidacion, int piezas)
                        :base(armadura, strikeArmadura, intimidacion, piezas)
        {

            Armadura = armadura;
            StrikeArmadura = strikeArmadura;
            Intimidacion = intimidacion;
            Piezas = piezas;

        }//fin del constructor


        //metodos
        //añadirStrike
        private void add_strike()
        {

            this.StrikeArmadura++;

        }

        //Desanimar
        private void desanimar(Personaje enemigo)
        {

            enemigo.Ataque -= 5;

        }
        
        
        //repararse
        private void repararse()
        {
            this.Vida += 50;
            this.Piezas--;


        }



    }//fin de la clase 



    class Animal : Personaje
    {

        public int Tamaño { get; set; }
        public int Garras { get; set; }
        public bool Veneno { get; set; }

        //constructor

        public Animal(string nombre, double vida, int nivel, double ataque, double defensa, double velocidad, string estado, int tamaño, int garras, bool veneno)
                     :base(tamaño, garras, veneno)
        {

            Tamaño = tamaño;
            Garras = garras;
            Veneno = veneno;



        }//fin del constructor 

        //metodos
        //envenenar
        private void envenenar(Personaje enemigo)
        {

            enemigo.Estado = "envenenado";


        }


        //aplastar
        private void aplastar(Personaje enemigo)
        {

            if (enemigo.Defensa >= 1000 && this.Tamaño>=500)
            {
                enemigo.Vida -= 80;
            }


        }


        //romper armadura
        private void  romperArmadura(Maquina enemigo)
        {

            enemigo.StrikeArmadura = 0;

        }



       

    }//fin de la clase 





}
