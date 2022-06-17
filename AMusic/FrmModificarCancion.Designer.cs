
namespace AMusic
{
    partial class FrmModificarCancion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModificarCancion));
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtista = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar1 = new AMusic.BotonRedondo();
            this.btnVolver1 = new AMusic.BotonRedondo();
            this.SuspendLayout();
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(124, 153);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(216, 24);
            this.cmbGenero.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Género";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Artista";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(121, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // txtArtista
            // 
            this.txtArtista.Location = new System.Drawing.Point(124, 108);
            this.txtArtista.Name = "txtArtista";
            this.txtArtista.Size = new System.Drawing.Size(216, 22);
            this.txtArtista.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 22);
            this.txtNombre.TabIndex = 6;
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
            this.btnAceptar1.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar1.Location = new System.Drawing.Point(50, 244);
            this.btnAceptar1.Name = "btnAceptar1";
            this.btnAceptar1.Size = new System.Drawing.Size(160, 48);
            this.btnAceptar1.TabIndex = 20;
            this.btnAceptar1.Text = "Añadir";
            this.btnAceptar1.TextColor = System.Drawing.Color.Black;
            this.btnAceptar1.UseVisualStyleBackColor = false;
            this.btnAceptar1.Click += new System.EventHandler(this.btnAceptar1_Click);
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
            this.btnVolver1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnVolver1.Location = new System.Drawing.Point(250, 244);
            this.btnVolver1.Name = "btnVolver1";
            this.btnVolver1.Size = new System.Drawing.Size(160, 48);
            this.btnVolver1.TabIndex = 21;
            this.btnVolver1.Text = "Volver";
            this.btnVolver1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnVolver1.UseVisualStyleBackColor = false;
            this.btnVolver1.Click += new System.EventHandler(this.btnVolver1_Click);
            // 
            // FrmModificarCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(473, 335);
            this.Controls.Add(this.btnVolver1);
            this.Controls.Add(this.btnAceptar1);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArtista);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModificarCancion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModificarCancion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtista;
        private System.Windows.Forms.TextBox txtNombre;
        private BotonRedondo btnAceptar1;
        private BotonRedondo btnVolver1;
    }
}