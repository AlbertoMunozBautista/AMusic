
namespace AMusic
{
    partial class FrmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarios));
            this.btnSeguir2 = new System.Windows.Forms.Button();
            this.lstPlaylist = new System.Windows.Forms.ListView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.picUsuarios = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeguir2
            // 
            this.btnSeguir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSeguir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguir2.ForeColor = System.Drawing.Color.White;
            this.btnSeguir2.Location = new System.Drawing.Point(351, 97);
            this.btnSeguir2.Name = "btnSeguir2";
            this.btnSeguir2.Size = new System.Drawing.Size(216, 60);
            this.btnSeguir2.TabIndex = 8;
            this.btnSeguir2.Text = "Seguir";
            this.btnSeguir2.UseVisualStyleBackColor = false;
            this.btnSeguir2.Click += new System.EventHandler(this.btnSeguir2_Click);
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.BackColor = System.Drawing.Color.Black;
            this.lstPlaylist.ForeColor = System.Drawing.Color.White;
            this.lstPlaylist.FullRowSelect = true;
            this.lstPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstPlaylist.HideSelection = false;
            this.lstPlaylist.Location = new System.Drawing.Point(61, 299);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(419, 271);
            this.lstPlaylist.TabIndex = 7;
            this.lstPlaylist.UseCompatibleStateImageBehavior = false;
            this.lstPlaylist.View = System.Windows.Forms.View.Details;
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(55, 247);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(93, 32);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "label1";
            // 
            // picUsuarios
            // 
            this.picUsuarios.Location = new System.Drawing.Point(61, 32);
            this.picUsuarios.Name = "picUsuarios";
            this.picUsuarios.Size = new System.Drawing.Size(224, 202);
            this.picUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuarios.TabIndex = 5;
            this.picUsuarios.TabStop = false;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(774, 609);
            this.Controls.Add(this.btnSeguir2);
            this.Controls.Add(this.lstPlaylist);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.picUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.picUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeguir2;
        private System.Windows.Forms.ListView lstPlaylist;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox picUsuarios;
    }
}