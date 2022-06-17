
namespace AMusic
{
    partial class FrmAnadirCancion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnadirCancion));
            this.prbProgreso = new System.Windows.Forms.ProgressBar();
            this.txtCancion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.picCaratula = new System.Windows.Forms.PictureBox();
            this.btnRecursos1 = new AMusic.BotonRedondo();
            this.btnCancion1 = new AMusic.BotonRedondo();
            this.btnCaratula1 = new AMusic.BotonRedondo();
            this.btnAceptar1 = new AMusic.BotonRedondo();
            this.btnVolver1 = new AMusic.BotonRedondo();
            this.ofdCaratula = new System.Windows.Forms.OpenFileDialog();
            this.ofdCancion = new System.Windows.Forms.OpenFileDialog();
            this.progressTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).BeginInit();
            this.SuspendLayout();
            // 
            // prbProgreso
            // 
            this.prbProgreso.Location = new System.Drawing.Point(184, 584);
            this.prbProgreso.MarqueeAnimationSpeed = 1000;
            this.prbProgreso.Name = "prbProgreso";
            this.prbProgreso.Size = new System.Drawing.Size(256, 23);
            this.prbProgreso.TabIndex = 22;
            // 
            // txtCancion
            // 
            this.txtCancion.Location = new System.Drawing.Point(335, 329);
            this.txtCancion.Name = "txtCancion";
            this.txtCancion.Size = new System.Drawing.Size(199, 22);
            this.txtCancion.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Género";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Artista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre";
            // 
            // cmbGenero
            // 
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(34, 419);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(199, 24);
            this.cmbGenero.TabIndex = 17;
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(34, 374);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(199, 22);
            this.txtArtista.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(34, 329);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(199, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // picCaratula
            // 
            this.picCaratula.Location = new System.Drawing.Point(34, 12);
            this.picCaratula.Name = "picCaratula";
            this.picCaratula.Size = new System.Drawing.Size(284, 284);
            this.picCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaratula.TabIndex = 14;
            this.picCaratula.TabStop = false;
            // 
            // btnRecursos1
            // 
            this.btnRecursos1.BackColor = System.Drawing.Color.White;
            this.btnRecursos1.BackgroundColor = System.Drawing.Color.White;
            this.btnRecursos1.BorderColor = System.Drawing.Color.White;
            this.btnRecursos1.BorderRadius = 0;
            this.btnRecursos1.BorderSize = 3;
            this.btnRecursos1.FlatAppearance.BorderSize = 0;
            this.btnRecursos1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecursos1.ForeColor = System.Drawing.Color.Black;
            this.btnRecursos1.Location = new System.Drawing.Point(234, 526);
            this.btnRecursos1.Name = "btnRecursos1";
            this.btnRecursos1.Size = new System.Drawing.Size(159, 52);
            this.btnRecursos1.TabIndex = 23;
            this.btnRecursos1.Text = "Subir Recursos";
            this.btnRecursos1.TextColor = System.Drawing.Color.Black;
            this.btnRecursos1.UseVisualStyleBackColor = false;
            this.btnRecursos1.Click += new System.EventHandler(this.btnRecursos1_Click);
            // 
            // btnCancion1
            // 
            this.btnCancion1.BackColor = System.Drawing.Color.Black;
            this.btnCancion1.BackgroundColor = System.Drawing.Color.Black;
            this.btnCancion1.BorderColor = System.Drawing.Color.White;
            this.btnCancion1.BorderRadius = 40;
            this.btnCancion1.BorderSize = 3;
            this.btnCancion1.FlatAppearance.BorderSize = 0;
            this.btnCancion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancion1.ForeColor = System.Drawing.Color.White;
            this.btnCancion1.Location = new System.Drawing.Point(359, 359);
            this.btnCancion1.Name = "btnCancion1";
            this.btnCancion1.Size = new System.Drawing.Size(159, 52);
            this.btnCancion1.TabIndex = 24;
            this.btnCancion1.Text = "Elegir Canción";
            this.btnCancion1.TextColor = System.Drawing.Color.White;
            this.btnCancion1.UseVisualStyleBackColor = false;
            this.btnCancion1.Click += new System.EventHandler(this.btnCancion1_Click);
            // 
            // btnCaratula1
            // 
            this.btnCaratula1.BackColor = System.Drawing.Color.Black;
            this.btnCaratula1.BackgroundColor = System.Drawing.Color.Black;
            this.btnCaratula1.BorderColor = System.Drawing.Color.White;
            this.btnCaratula1.BorderRadius = 40;
            this.btnCaratula1.BorderSize = 3;
            this.btnCaratula1.FlatAppearance.BorderSize = 0;
            this.btnCaratula1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaratula1.ForeColor = System.Drawing.Color.White;
            this.btnCaratula1.Location = new System.Drawing.Point(335, 111);
            this.btnCaratula1.Name = "btnCaratula1";
            this.btnCaratula1.Size = new System.Drawing.Size(218, 60);
            this.btnCaratula1.TabIndex = 25;
            this.btnCaratula1.Text = "Elegir Carátula";
            this.btnCaratula1.TextColor = System.Drawing.Color.White;
            this.btnCaratula1.UseVisualStyleBackColor = false;
            this.btnCaratula1.Click += new System.EventHandler(this.btnCaratula1_Click);
            // 
            // btnAceptar1
            // 
            this.btnAceptar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar1.BorderRadius = 40;
            this.btnAceptar1.BorderSize = 0;
            this.btnAceptar1.FlatAppearance.BorderSize = 0;
            this.btnAceptar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar1.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar1.Location = new System.Drawing.Point(46, 650);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(223, 48);
            this.btnAceptar1.TabIndex = 26;
            this.btnAceptar1.Text = "Añadir";
            this.btnAceptar1.TextColor = System.Drawing.Color.Black;
            this.btnAceptar1.UseVisualStyleBackColor = false;
            this.btnAceptar1.Click += new System.EventHandler(this.btnAceptar1_Click_1);
            // 
            // btnVolver1
            // 
            this.btnVolver1.BackColor = System.Drawing.Color.Black;
            this.btnVolver1.BackgroundColor = System.Drawing.Color.Black;
            this.btnVolver1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnVolver1.BorderRadius = 40;
            this.btnVolver1.BorderSize = 3;
            this.btnVolver1.FlatAppearance.BorderSize = 0;
            this.btnVolver1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnVolver1.Location = new System.Drawing.Point(311, 650);
            this.btnVolver1.Name = "btnVolver1";
            this.btnVolver1.Size = new System.Drawing.Size(223, 48);
            this.btnVolver1.TabIndex = 27;
            this.btnVolver1.Text = "Volver";
            this.btnVolver1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnVolver1.UseVisualStyleBackColor = false;
            this.btnVolver1.Click += new System.EventHandler(this.btnVolver1_Click);
            // 
            // ofdCaratula
            // 
            this.ofdCaratula.FileName = "openFileDialog1";
            // 
            // ofdCancion
            // 
            this.ofdCancion.FileName = "openFileDialog1";
            // 
            // progressTime
            // 
            this.progressTime.Tick += new System.EventHandler(this.progressTime_Tick);
            // 
            // FrmAnadirCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(612, 734);
            this.Controls.Add(this.btnVolver1);
            this.Controls.Add(this.btnAceptar1);
            this.Controls.Add(this.btnCaratula1);
            this.Controls.Add(this.btnCancion1);
            this.Controls.Add(this.btnRecursos1);
            this.Controls.Add(this.prbProgreso);
            this.Controls.Add(this.txtCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.picCaratula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnadirCancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnadirCancion";
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prbProgreso;
        private System.Windows.Forms.TextBox txtCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox picCaratula;
        private BotonRedondo btnRecursos1;
        private BotonRedondo btnCancion1;
        private BotonRedondo btnCaratula1;
        private BotonRedondo btnAceptar1;
        private BotonRedondo btnVolver1;
        private System.Windows.Forms.OpenFileDialog ofdCaratula;
        private System.Windows.Forms.OpenFileDialog ofdCancion;
        private System.Windows.Forms.Timer progressTime;
    }
}