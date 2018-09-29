namespace ANCIENT_WARS
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnInstrucciones = new System.Windows.Forms.Button();
            this.btnComenzarPartida = new System.Windows.Forms.Button();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descripcionDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.fondo1;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSalida);
            this.panel1.Controls.Add(this.btnInstrucciones);
            this.panel1.Controls.Add(this.btnComenzarPartida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 509);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ANCIENT_WARS.Properties.Resources.titulo;
            this.pictureBox1.Image = global::ANCIENT_WARS.Properties.Resources.titulo;
            this.pictureBox1.Location = new System.Drawing.Point(-112, -63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalida
            // 
            this.btnSalida.AutoEllipsis = true;
            this.btnSalida.BackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnSalida.FlatAppearance.BorderSize = 3;
            this.btnSalida.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSalida.Location = new System.Drawing.Point(301, 383);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(234, 37);
            this.btnSalida.TabIndex = 2;
            this.btnSalida.Text = "Salir";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnInstrucciones
            // 
            this.btnInstrucciones.AutoEllipsis = true;
            this.btnInstrucciones.BackColor = System.Drawing.Color.Transparent;
            this.btnInstrucciones.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnInstrucciones.FlatAppearance.BorderSize = 3;
            this.btnInstrucciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnInstrucciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnInstrucciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstrucciones.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnInstrucciones.Location = new System.Drawing.Point(301, 340);
            this.btnInstrucciones.Name = "btnInstrucciones";
            this.btnInstrucciones.Size = new System.Drawing.Size(234, 37);
            this.btnInstrucciones.TabIndex = 1;
            this.btnInstrucciones.Text = "Instrucciones";
            this.btnInstrucciones.UseVisualStyleBackColor = false;
            // 
            // btnComenzarPartida
            // 
            this.btnComenzarPartida.AutoEllipsis = true;
            this.btnComenzarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnComenzarPartida.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnComenzarPartida.FlatAppearance.BorderSize = 3;
            this.btnComenzarPartida.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnComenzarPartida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnComenzarPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzarPartida.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnComenzarPartida.Location = new System.Drawing.Point(301, 297);
            this.btnComenzarPartida.Name = "btnComenzarPartida";
            this.btnComenzarPartida.Size = new System.Drawing.Size(234, 37);
            this.btnComenzarPartida.TabIndex = 0;
            this.btnComenzarPartida.Text = "Empezar a Jugar";
            this.btnComenzarPartida.UseVisualStyleBackColor = false;
            this.btnComenzarPartida.Click += new System.EventHandler(this.btnComenzarPartida_Click);
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
            this.salirToolStripMenuItem.Text = "salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descripcionDelJuegoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // descripcionDelJuegoToolStripMenuItem
            // 
            this.descripcionDelJuegoToolStripMenuItem.Name = "descripcionDelJuegoToolStripMenuItem";
            this.descripcionDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.descripcionDelJuegoToolStripMenuItem.Text = "descripcion del juego";
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Text = "Ancient_WARS- Joni";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descripcionDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnInstrucciones;
        private System.Windows.Forms.Button btnComenzarPartida;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

