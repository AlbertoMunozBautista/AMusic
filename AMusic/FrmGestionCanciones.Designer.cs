
namespace AMusic
{
    partial class FrmGestionCanciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionCanciones));
            this.dgvCanciones = new System.Windows.Forms.DataGridView();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnadir1 = new AMusic.BotonRedondo();
            this.btnEliminar1 = new AMusic.BotonRedondo();
            this.btnModificar1 = new AMusic.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCanciones
            // 
            this.dgvCanciones.AllowUserToAddRows = false;
            this.dgvCanciones.AllowUserToDeleteRows = false;
            this.dgvCanciones.AllowUserToResizeColumns = false;
            this.dgvCanciones.AllowUserToResizeRows = false;
            this.dgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanciones.Location = new System.Drawing.Point(12, 94);
            this.dgvCanciones.MultiSelect = false;
            this.dgvCanciones.Name = "dgvCanciones";
            this.dgvCanciones.ReadOnly = true;
            this.dgvCanciones.RowHeadersVisible = false;
            this.dgvCanciones.RowHeadersWidth = 51;
            this.dgvCanciones.RowTemplate.Height = 24;
            this.dgvCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanciones.Size = new System.Drawing.Size(1204, 466);
            this.dgvCanciones.TabIndex = 11;
            this.dgvCanciones.DoubleClick += new System.EventHandler(this.dgvCanciones_DoubleClick);
            // 
            // picSalir
            // 
            this.picSalir.Image = global::AMusic.Properties.Resources.close1;
            this.picSalir.Location = new System.Drawing.Point(1144, 12);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(72, 67);
            this.picSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSalir.TabIndex = 12;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMusic.Properties.Resources.flecha;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // btnAnadir1
            // 
            this.btnAnadir1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAnadir1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAnadir1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnadir1.BorderRadius = 40;
            this.btnAnadir1.BorderSize = 0;
            this.btnAnadir1.FlatAppearance.BorderSize = 0;
            this.btnAnadir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir1.ForeColor = System.Drawing.Color.White;
            this.btnAnadir1.Location = new System.Drawing.Point(38, 605);
            this.btnAnadir1.Name = "btnAnadir1";
            this.btnAnadir1.Size = new System.Drawing.Size(209, 57);
            this.btnAnadir1.TabIndex = 11;
            this.btnAnadir1.Text = "Añadir";
            this.btnAnadir1.TextColor = System.Drawing.Color.White;
            this.btnAnadir1.UseVisualStyleBackColor = false;
            this.btnAnadir1.Click += new System.EventHandler(this.btnAnadir1_Click_1);
            // 
            // btnEliminar1
            // 
            this.btnEliminar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnEliminar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnEliminar1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar1.BorderRadius = 40;
            this.btnEliminar1.BorderSize = 0;
            this.btnEliminar1.FlatAppearance.BorderSize = 0;
            this.btnEliminar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar1.ForeColor = System.Drawing.Color.White;
            this.btnEliminar1.Location = new System.Drawing.Point(506, 605);
            this.btnEliminar1.Name = "btnEliminar1";
            this.btnEliminar1.Size = new System.Drawing.Size(209, 57);
            this.btnEliminar1.TabIndex = 13;
            this.btnEliminar1.Text = "Eliminar";
            this.btnEliminar1.TextColor = System.Drawing.Color.White;
            this.btnEliminar1.UseVisualStyleBackColor = false;
            this.btnEliminar1.Click += new System.EventHandler(this.btnEliminar1_Click);
            // 
            // btnModificar1
            // 
            this.btnModificar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnModificar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnModificar1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnModificar1.BorderRadius = 40;
            this.btnModificar1.BorderSize = 0;
            this.btnModificar1.FlatAppearance.BorderSize = 0;
            this.btnModificar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar1.ForeColor = System.Drawing.Color.White;
            this.btnModificar1.Location = new System.Drawing.Point(977, 605);
            this.btnModificar1.Name = "btnModificar1";
            this.btnModificar1.Size = new System.Drawing.Size(209, 57);
            this.btnModificar1.TabIndex = 14;
            this.btnModificar1.Text = "Modificar";
            this.btnModificar1.TextColor = System.Drawing.Color.White;
            this.btnModificar1.UseVisualStyleBackColor = false;
            this.btnModificar1.Click += new System.EventHandler(this.btnModificar1_Click);
            // 
            // FrmGestionCanciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1228, 697);
            this.Controls.Add(this.btnModificar1);
            this.Controls.Add(this.btnEliminar1);
            this.Controls.Add(this.btnAnadir1);
            this.Controls.Add(this.picSalir);
            this.Controls.Add(this.dgvCanciones);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionCanciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGestionCanciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.DataGridView dgvCanciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BotonRedondo btnAnadir1;
        private BotonRedondo btnEliminar1;
        private BotonRedondo btnModificar1;
    }
}