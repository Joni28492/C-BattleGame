namespace ANCIENT_WARS
{
    partial class Form2
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
            this.MenuPersonaje = new System.Windows.Forms.Panel();
            this.btnBatalla = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGrifo = new System.Windows.Forms.PictureBox();
            this.pbMaquina = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbHumano = new System.Windows.Forms.PictureBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHumano = new System.Windows.Forms.Button();
            this.btnMaquina = new System.Windows.Forms.Button();
            this.btnBestia = new System.Windows.Forms.Button();
            this.MenuPersonaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrifo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaquina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumano)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPersonaje
            // 
            this.MenuPersonaje.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.fondo6;
            this.MenuPersonaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuPersonaje.Controls.Add(this.btnBestia);
            this.MenuPersonaje.Controls.Add(this.btnMaquina);
            this.MenuPersonaje.Controls.Add(this.btnHumano);
            this.MenuPersonaje.Controls.Add(this.btnBatalla);
            this.MenuPersonaje.Controls.Add(this.pictureBox1);
            this.MenuPersonaje.Controls.Add(this.pbGrifo);
            this.MenuPersonaje.Controls.Add(this.pbMaquina);
            this.MenuPersonaje.Controls.Add(this.label2);
            this.MenuPersonaje.Controls.Add(this.pbHumano);
            this.MenuPersonaje.Controls.Add(this.lblDescripcion);
            this.MenuPersonaje.Controls.Add(this.menuStrip1);
            this.MenuPersonaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPersonaje.Location = new System.Drawing.Point(0, 0);
            this.MenuPersonaje.Name = "MenuPersonaje";
            this.MenuPersonaje.Size = new System.Drawing.Size(836, 533);
            this.MenuPersonaje.TabIndex = 0;
            // 
            // btnBatalla
            // 
            this.btnBatalla.Location = new System.Drawing.Point(599, 459);
            this.btnBatalla.Name = "btnBatalla";
            this.btnBatalla.Size = new System.Drawing.Size(185, 35);
            this.btnBatalla.TabIndex = 9;
            this.btnBatalla.Text = "Comienza la aventura";
            this.btnBatalla.UseVisualStyleBackColor = true;
            this.btnBatalla.Click += new System.EventHandler(this.btnBatalla_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ANCIENT_WARS.Properties.Resources.humano;
            this.pictureBox1.Location = new System.Drawing.Point(69, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pbGrifo
            // 
            this.pbGrifo.BackColor = System.Drawing.Color.Transparent;
            this.pbGrifo.Image = global::ANCIENT_WARS.Properties.Resources.grifo1;
            this.pbGrifo.Location = new System.Drawing.Point(377, 364);
            this.pbGrifo.Name = "pbGrifo";
            this.pbGrifo.Size = new System.Drawing.Size(124, 118);
            this.pbGrifo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGrifo.TabIndex = 6;
            this.pbGrifo.TabStop = false;
            this.pbGrifo.MouseHover += new System.EventHandler(this.pbGrifo_MouseHover);
            // 
            // pbMaquina
            // 
            this.pbMaquina.BackColor = System.Drawing.Color.Transparent;
            this.pbMaquina.Image = global::ANCIENT_WARS.Properties.Resources.maquina;
            this.pbMaquina.Location = new System.Drawing.Point(219, 364);
            this.pbMaquina.Name = "pbMaquina";
            this.pbMaquina.Size = new System.Drawing.Size(124, 118);
            this.pbMaquina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMaquina.TabIndex = 5;
            this.pbMaquina.TabStop = false;
            this.pbMaquina.MouseHover += new System.EventHandler(this.pbMaquina_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(23, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "dinero";
            // 
            // pbHumano
            // 
            this.pbHumano.BackColor = System.Drawing.Color.Transparent;
            this.pbHumano.Image = global::ANCIENT_WARS.Properties.Resources.humano;
            this.pbHumano.Location = new System.Drawing.Point(48, 364);
            this.pbHumano.Name = "pbHumano";
            this.pbHumano.Size = new System.Drawing.Size(124, 118);
            this.pbHumano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumano.TabIndex = 1;
            this.pbHumano.TabStop = false;
            this.pbHumano.MouseHover += new System.EventHandler(this.pbHumano_MouseHover);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.Snow;
            this.lblDescripcion.Location = new System.Drawing.Point(566, 43);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(218, 20);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "descripcion de personajes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 8;
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
            this.instruccionesToolStripMenuItem.Text = "instrucciones";
            // 
            // btnHumano
            // 
            this.btnHumano.Enabled = false;
            this.btnHumano.Location = new System.Drawing.Point(60, 488);
            this.btnHumano.Name = "btnHumano";
            this.btnHumano.Size = new System.Drawing.Size(92, 23);
            this.btnHumano.TabIndex = 10;
            this.btnHumano.Text = "humano";
            this.btnHumano.UseVisualStyleBackColor = true;
            this.btnHumano.Click += new System.EventHandler(this.btnHumano_Click);
            // 
            // btnMaquina
            // 
            this.btnMaquina.Location = new System.Drawing.Point(235, 488);
            this.btnMaquina.Name = "btnMaquina";
            this.btnMaquina.Size = new System.Drawing.Size(92, 23);
            this.btnMaquina.TabIndex = 11;
            this.btnMaquina.Text = "maquina";
            this.btnMaquina.UseVisualStyleBackColor = true;
            this.btnMaquina.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBestia
            // 
            this.btnBestia.Location = new System.Drawing.Point(394, 488);
            this.btnBestia.Name = "btnBestia";
            this.btnBestia.Size = new System.Drawing.Size(92, 23);
            this.btnBestia.TabIndex = 12;
            this.btnBestia.Text = "bestia";
            this.btnBestia.UseVisualStyleBackColor = true;
            this.btnBestia.Click += new System.EventHandler(this.btnBestia_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.MenuPersonaje);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MenuPersonaje.ResumeLayout(false);
            this.MenuPersonaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrifo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaquina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumano)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPersonaje;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbHumano;
        private System.Windows.Forms.PictureBox pbGrifo;
        private System.Windows.Forms.PictureBox pbMaquina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruccionesToolStripMenuItem;
        private System.Windows.Forms.Button btnBatalla;
        private System.Windows.Forms.Button btnBestia;
        private System.Windows.Forms.Button btnMaquina;
        private System.Windows.Forms.Button btnHumano;
    }
}