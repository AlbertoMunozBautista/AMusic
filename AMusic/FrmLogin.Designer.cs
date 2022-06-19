
namespace AMusic
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picCerrar = new System.Windows.Forms.PictureBox();
            this.txtRegistro = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new AMusic.txtRedondo();
            this.txtUsuario = new AMusic.txtRedondo();
            this.btnLogin1 = new AMusic.BotonRedondo();
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCerrar
            // 
            this.picCerrar.BackColor = System.Drawing.Color.Transparent;
            this.picCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCerrar.Image = global::AMusic.Properties.Resources.closeRojo;
            this.picCerrar.Location = new System.Drawing.Point(1352, 12);
            this.picCerrar.Name = "picCerrar";
            this.picCerrar.Size = new System.Drawing.Size(100, 100);
            this.picCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCerrar.TabIndex = 14;
            this.picCerrar.TabStop = false;
            this.picCerrar.Click += new System.EventHandler(this.picCerrar_Click);
            // 
            // txtRegistro
            // 
            this.txtRegistro.AutoSize = true;
            this.txtRegistro.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistro.ForeColor = System.Drawing.Color.White;
            this.txtRegistro.Location = new System.Drawing.Point(633, 540);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(245, 29);
            this.txtRegistro.TabIndex = 13;
            this.txtRegistro.Text = "¿no tienes cuenta?";
            this.txtRegistro.Click += new System.EventHandler(this.txtRegistro_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::AMusic.Properties.Resources.icono;
            this.pictureBox2.Location = new System.Drawing.Point(577, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 327);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(616, 417);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholcerText = "contraseña";
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Size = new System.Drawing.Size(262, 35);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlineStyle = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderFocusColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.BorderRadius = 0;
            this.txtUsuario.BorderSize = 2;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(616, 358);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsuario.Multiline = false;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuario.PasswordChar = false;
            this.txtUsuario.PlaceholcerText = "usuario";
            this.txtUsuario.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Size = new System.Drawing.Size(262, 35);
            this.txtUsuario.TabIndex = 9;
            this.txtUsuario.Texts = "";
            this.txtUsuario.UnderlineStyle = false;
            // 
            // btnLogin1
            // 
            this.btnLogin1.BackColor = System.Drawing.Color.Black;
            this.btnLogin1.BackgroundColor = System.Drawing.Color.Black;
            this.btnLogin1.BorderColor = System.Drawing.Color.White;
            this.btnLogin1.BorderRadius = 0;
            this.btnLogin1.BorderSize = 2;
            this.btnLogin1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin1.FlatAppearance.BorderSize = 0;
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin1.Font = new System.Drawing.Font("Arial Narrow", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.ForeColor = System.Drawing.Color.White;
            this.btnLogin1.Location = new System.Drawing.Point(666, 483);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(164, 54);
            this.btnLogin1.TabIndex = 8;
            this.btnLogin1.Text = "Log In";
            this.btnLogin1.TextColor = System.Drawing.Color.White;
            this.btnLogin1.UseVisualStyleBackColor = false;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click_1);
            this.btnLogin1.MouseEnter += new System.EventHandler(this.btnLogin1_MouseEnter_1);
            this.btnLogin1.MouseLeave += new System.EventHandler(this.btnLogin1_MouseLeave_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AMusic.Properties.Resources.fondoLogin;
            this.ClientSize = new System.Drawing.Size(1464, 706);
            this.Controls.Add(this.btnLogin1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.picCerrar);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCerrar;
        private System.Windows.Forms.Label txtRegistro;
        private System.Windows.Forms.PictureBox pictureBox2;
        private txtRedondo txtUsuario;
        private txtRedondo txtPassword;
        private BotonRedondo btnLogin1;
    }
}