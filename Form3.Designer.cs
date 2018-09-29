namespace ANCIENT_WARS
{
    partial class Form3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbVidaEnemigo = new System.Windows.Forms.PictureBox();
            this.lblDialogo = new System.Windows.Forms.Label();
            this.btnEspecialTres = new System.Windows.Forms.Button();
            this.btnEspecialDos = new System.Windows.Forms.Button();
            this.btnEspecialUno = new System.Windows.Forms.Button();
            this.btnRecuperarse = new System.Windows.Forms.Button();
            this.btnCubrirse = new System.Windows.Forms.Button();
            this.btnAtaqueNormal = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pbJugador = new System.Windows.Forms.PictureBox();
            this.pbVidaJugador = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbVidaEnemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVidaJugador)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPartidaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaPartidaToolStripMenuItem
            // 
            this.nuevaPartidaToolStripMenuItem.Name = "nuevaPartidaToolStripMenuItem";
            this.nuevaPartidaToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nuevaPartidaToolStripMenuItem.Text = "Nueva Partida";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instruccionesToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // instruccionesToolStripMenuItem
            // 
            this.instruccionesToolStripMenuItem.Name = "instruccionesToolStripMenuItem";
            this.instruccionesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.instruccionesToolStripMenuItem.Text = "Instrucciones";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.fondo2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbVidaEnemigo);
            this.panel1.Controls.Add(this.lblDialogo);
            this.panel1.Controls.Add(this.btnEspecialTres);
            this.panel1.Controls.Add(this.btnEspecialDos);
            this.panel1.Controls.Add(this.btnEspecialUno);
            this.panel1.Controls.Add(this.btnRecuperarse);
            this.panel1.Controls.Add(this.btnCubrirse);
            this.panel1.Controls.Add(this.btnAtaqueNormal);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pbJugador);
            this.panel1.Controls.Add(this.pbVidaJugador);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 509);
            this.panel1.TabIndex = 1;
            // 
            // pbVidaEnemigo
            // 
            this.pbVidaEnemigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbVidaEnemigo.Location = new System.Drawing.Point(559, 36);
            this.pbVidaEnemigo.Name = "pbVidaEnemigo";
            this.pbVidaEnemigo.Size = new System.Drawing.Size(223, 29);
            this.pbVidaEnemigo.TabIndex = 10;
            this.pbVidaEnemigo.TabStop = false;
            // 
            // lblDialogo
            // 
            this.lblDialogo.BackColor = System.Drawing.Color.DimGray;
            this.lblDialogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogo.ForeColor = System.Drawing.Color.Yellow;
            this.lblDialogo.Location = new System.Drawing.Point(282, 176);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(271, 99);
            this.lblDialogo.TabIndex = 9;
            this.lblDialogo.Text = "lo que va ocurriendo";
            // 
            // btnEspecialTres
            // 
            this.btnEspecialTres.Location = new System.Drawing.Point(93, 129);
            this.btnEspecialTres.Name = "btnEspecialTres";
            this.btnEspecialTres.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialTres.TabIndex = 8;
            this.btnEspecialTres.Text = "trampa";
            this.btnEspecialTres.UseVisualStyleBackColor = true;
            this.btnEspecialTres.Click += new System.EventHandler(this.btnEspecialTres_Click);
            // 
            // btnEspecialDos
            // 
            this.btnEspecialDos.Location = new System.Drawing.Point(12, 129);
            this.btnEspecialDos.Name = "btnEspecialDos";
            this.btnEspecialDos.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialDos.TabIndex = 7;
            this.btnEspecialDos.Text = "motivacion";
            this.btnEspecialDos.UseVisualStyleBackColor = true;
            this.btnEspecialDos.Click += new System.EventHandler(this.btnEspecialDos_Click);
            // 
            // btnEspecialUno
            // 
            this.btnEspecialUno.Location = new System.Drawing.Point(93, 100);
            this.btnEspecialUno.Name = "btnEspecialUno";
            this.btnEspecialUno.Size = new System.Drawing.Size(75, 23);
            this.btnEspecialUno.TabIndex = 6;
            this.btnEspecialUno.Text = "paralizar";
            this.btnEspecialUno.UseVisualStyleBackColor = true;
            this.btnEspecialUno.Click += new System.EventHandler(this.btnEspacialUno_Click);
            // 
            // btnRecuperarse
            // 
            this.btnRecuperarse.Location = new System.Drawing.Point(12, 100);
            this.btnRecuperarse.Name = "btnRecuperarse";
            this.btnRecuperarse.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperarse.TabIndex = 5;
            this.btnRecuperarse.Text = "recuperarse";
            this.btnRecuperarse.UseVisualStyleBackColor = true;
            this.btnRecuperarse.Click += new System.EventHandler(this.btnRecuperarse_Click);
            // 
            // btnCubrirse
            // 
            this.btnCubrirse.Location = new System.Drawing.Point(93, 71);
            this.btnCubrirse.Name = "btnCubrirse";
            this.btnCubrirse.Size = new System.Drawing.Size(75, 23);
            this.btnCubrirse.TabIndex = 4;
            this.btnCubrirse.Text = "cubrirse";
            this.btnCubrirse.UseVisualStyleBackColor = true;
            this.btnCubrirse.Click += new System.EventHandler(this.btnCubrirse_Click);
            // 
            // btnAtaqueNormal
            // 
            this.btnAtaqueNormal.Location = new System.Drawing.Point(12, 71);
            this.btnAtaqueNormal.Name = "btnAtaqueNormal";
            this.btnAtaqueNormal.Size = new System.Drawing.Size(75, 23);
            this.btnAtaqueNormal.TabIndex = 2;
            this.btnAtaqueNormal.Text = "atacar";
            this.btnAtaqueNormal.UseVisualStyleBackColor = true;
            this.btnAtaqueNormal.Click += new System.EventHandler(this.btnAtaqueNormal_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.grifo2;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(559, 235);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(255, 240);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pbJugador
            // 
            this.pbJugador.BackColor = System.Drawing.Color.Transparent;
            this.pbJugador.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.humano;
            this.pbJugador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbJugador.Location = new System.Drawing.Point(12, 235);
            this.pbJugador.Name = "pbJugador";
            this.pbJugador.Size = new System.Drawing.Size(255, 240);
            this.pbJugador.TabIndex = 2;
            this.pbJugador.TabStop = false;
            // 
            // pbVidaJugador
            // 
            this.pbVidaJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbVidaJugador.Location = new System.Drawing.Point(12, 36);
            this.pbVidaJugador.Name = "pbVidaJugador";
            this.pbVidaJugador.Size = new System.Drawing.Size(223, 29);
            this.pbVidaJugador.TabIndex = 0;
            this.pbVidaJugador.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbVidaEnemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJugador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVidaJugador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pbJugador;
        private System.Windows.Forms.PictureBox pbVidaJugador;
        private System.Windows.Forms.Button btnEspecialTres;
        private System.Windows.Forms.Button btnEspecialDos;
        private System.Windows.Forms.Button btnEspecialUno;
        private System.Windows.Forms.Button btnRecuperarse;
        private System.Windows.Forms.Button btnCubrirse;
        private System.Windows.Forms.Button btnAtaqueNormal;
        private System.Windows.Forms.Label lblDialogo;
        private System.Windows.Forms.PictureBox pbVidaEnemigo;
    }
}