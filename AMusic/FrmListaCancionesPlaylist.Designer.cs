
namespace AMusic
{
    partial class FrmListaCancionesPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaCancionesPlaylist));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lstCancion = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picBorrar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.picReproducir = new System.Windows.Forms.PictureBox();
            this.picCorazon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picReproducir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(80, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(79, 29);
            this.lblUsuario.TabIndex = 15;
            this.lblUsuario.Text = "label1";
            // 
            // lstCancion
            // 
            this.lstCancion.BackColor = System.Drawing.Color.Black;
            this.lstCancion.ForeColor = System.Drawing.Color.White;
            this.lstCancion.FullRowSelect = true;
            this.lstCancion.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstCancion.HideSelection = false;
            this.lstCancion.Location = new System.Drawing.Point(85, 137);
            this.lstCancion.Name = "lstCancion";
            this.lstCancion.Size = new System.Drawing.Size(503, 461);
            this.lstCancion.TabIndex = 14;
            this.lstCancion.UseCompatibleStateImageBehavior = false;
            this.lstCancion.View = System.Windows.Forms.View.Details;
            this.lstCancion.DoubleClick += new System.EventHandler(this.lstCancion_DoubleClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(78, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(109, 39);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "label1";
            // 
            // picBorrar
            // 
            this.picBorrar.ActiveImage = null;
            this.picBorrar.AllowAnimations = true;
            this.picBorrar.AllowBuffering = false;
            this.picBorrar.AllowToggling = false;
            this.picBorrar.AllowZooming = true;
            this.picBorrar.AllowZoomingOnFocus = false;
            this.picBorrar.BackColor = System.Drawing.Color.Transparent;
            this.picBorrar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.picBorrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBorrar.ErrorImage")));
            this.picBorrar.FadeWhenInactive = false;
            this.picBorrar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.picBorrar.Image = global::AMusic.Properties.Resources.basura;
            this.picBorrar.ImageActive = null;
            this.picBorrar.ImageLocation = null;
            this.picBorrar.ImageMargin = 0;
            this.picBorrar.ImageSize = new System.Drawing.Size(35, 34);
            this.picBorrar.ImageZoomSize = new System.Drawing.Size(36, 35);
            this.picBorrar.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBorrar.InitialImage")));
            this.picBorrar.Location = new System.Drawing.Point(663, 563);
            this.picBorrar.Name = "picBorrar";
            this.picBorrar.Rotation = 0;
            this.picBorrar.ShowActiveImage = true;
            this.picBorrar.ShowCursorChanges = true;
            this.picBorrar.ShowImageBorders = true;
            this.picBorrar.ShowSizeMarkers = false;
            this.picBorrar.Size = new System.Drawing.Size(36, 35);
            this.picBorrar.TabIndex = 18;
            this.picBorrar.ToolTipText = "";
            this.picBorrar.WaitOnLoad = false;
            this.picBorrar.Zoom = 0;
            this.picBorrar.ZoomSpeed = 10;
            this.picBorrar.Click += new System.EventHandler(this.picBorrar_Click);
            // 
            // picReproducir
            // 
            this.picReproducir.Image = global::AMusic.Properties.Resources.reproducir;
            this.picReproducir.Location = new System.Drawing.Point(630, 137);
            this.picReproducir.Name = "picReproducir";
            this.picReproducir.Size = new System.Drawing.Size(69, 69);
            this.picReproducir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReproducir.TabIndex = 17;
            this.picReproducir.TabStop = false;
            this.picReproducir.Click += new System.EventHandler(this.picReproducir_Click);
            // 
            // picCorazon
            // 
            this.picCorazon.Image = global::AMusic.Properties.Resources.megusta;
            this.picCorazon.Location = new System.Drawing.Point(630, 47);
            this.picCorazon.Name = "picCorazon";
            this.picCorazon.Size = new System.Drawing.Size(69, 69);
            this.picCorazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCorazon.TabIndex = 16;
            this.picCorazon.TabStop = false;
            this.picCorazon.Click += new System.EventHandler(this.picCorazon_Click);
            // 
            // FrmListaCancionesPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(776, 634);
            this.Controls.Add(this.picBorrar);
            this.Controls.Add(this.picReproducir);
            this.Controls.Add(this.picCorazon);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lstCancion);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaCancionesPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListaCancionesPlaylist";
            ((System.ComponentModel.ISupportInitialize)(this.picReproducir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuImageButton picBorrar;
        private System.Windows.Forms.PictureBox picReproducir;
        private System.Windows.Forms.PictureBox picCorazon;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ListView lstCancion;
        private System.Windows.Forms.Label lblNombre;
    }
}