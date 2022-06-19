
namespace AMusic
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            this.tabEditarPerfil = new System.Windows.Forms.TabControl();
            this.tabPerfil = new System.Windows.Forms.TabPage();
            this.btnCancelar = new AMusic.BotonRedondo();
            this.btnAceptar = new AMusic.BotonRedondo();
            this.btnActualizar = new AMusic.BotonRedondo();
            this.btnCambiarFoto = new AMusic.BotonRedondo();
            this.txtTelefono = new AMusic.txtRedondo();
            this.txtPassword = new AMusic.txtRedondo();
            this.txtCorreo = new AMusic.txtRedondo();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.tabSeguidos = new System.Windows.Forms.TabPage();
            this.lstUsuarios = new System.Windows.Forms.ListView();
            this.tabPlaylist = new System.Windows.Forms.TabPage();
            this.lstPlaylist = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tabEditarPerfil.SuspendLayout();
            this.tabPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.tabSeguidos.SuspendLayout();
            this.tabPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEditarPerfil
            // 
            this.tabEditarPerfil.Controls.Add(this.tabPerfil);
            this.tabEditarPerfil.Controls.Add(this.tabSeguidos);
            this.tabEditarPerfil.Controls.Add(this.tabPlaylist);
            this.tabEditarPerfil.Location = new System.Drawing.Point(14, 37);
            this.tabEditarPerfil.Name = "tabEditarPerfil";
            this.tabEditarPerfil.SelectedIndex = 0;
            this.tabEditarPerfil.Size = new System.Drawing.Size(718, 547);
            this.tabEditarPerfil.TabIndex = 1;
            // 
            // tabPerfil
            // 
            this.tabPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tabPerfil.Controls.Add(this.btnCancelar);
            this.tabPerfil.Controls.Add(this.btnAceptar);
            this.tabPerfil.Controls.Add(this.btnActualizar);
            this.tabPerfil.Controls.Add(this.btnCambiarFoto);
            this.tabPerfil.Controls.Add(this.txtTelefono);
            this.tabPerfil.Controls.Add(this.txtPassword);
            this.tabPerfil.Controls.Add(this.txtCorreo);
            this.tabPerfil.Controls.Add(this.bunifuSeparator1);
            this.tabPerfil.Controls.Add(this.txtUsuario);
            this.tabPerfil.Controls.Add(this.picPassword);
            this.tabPerfil.Controls.Add(this.label3);
            this.tabPerfil.Controls.Add(this.label2);
            this.tabPerfil.Controls.Add(this.label1);
            this.tabPerfil.Controls.Add(this.lbl1);
            this.tabPerfil.Controls.Add(this.picFoto);
            this.tabPerfil.Location = new System.Drawing.Point(4, 25);
            this.tabPerfil.Name = "tabPerfil";
            this.tabPerfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerfil.Size = new System.Drawing.Size(710, 518);
            this.tabPerfil.TabIndex = 0;
            this.tabPerfil.Text = "Perfil";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 2;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(394, 443);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(199, 51);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnAceptar.BorderRadius = 20;
            this.btnAceptar.BorderSize = 2;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(83, 443);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(199, 51);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextColor = System.Drawing.Color.White;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnActualizar.BorderColor = System.Drawing.Color.White;
            this.btnActualizar.BorderRadius = 15;
            this.btnActualizar.BorderSize = 2;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(163, 335);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(119, 47);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar foto";
            this.btnActualizar.TextColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.BackColor = System.Drawing.Color.Transparent;
            this.btnCambiarFoto.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnCambiarFoto.BorderColor = System.Drawing.Color.White;
            this.btnCambiarFoto.BorderRadius = 15;
            this.btnCambiarFoto.BorderSize = 2;
            this.btnCambiarFoto.FlatAppearance.BorderSize = 0;
            this.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFoto.ForeColor = System.Drawing.Color.White;
            this.btnCambiarFoto.Location = new System.Drawing.Point(23, 335);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(119, 47);
            this.btnCambiarFoto.TabIndex = 20;
            this.btnCambiarFoto.Text = "Cambiar foto";
            this.btnCambiarFoto.TextColor = System.Drawing.Color.White;
            this.btnCambiarFoto.UseVisualStyleBackColor = false;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtTelefono.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtTelefono.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtTelefono.BorderRadius = 10;
            this.txtTelefono.BorderSize = 2;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(372, 283);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTelefono.Multiline = false;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefono.PasswordChar = false;
            this.txtTelefono.PlaceholcerText = "";
            this.txtTelefono.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTelefono.Size = new System.Drawing.Size(250, 35);
            this.txtTelefono.TabIndex = 19;
            this.txtTelefono.Texts = "";
            this.txtTelefono.UnderlineStyle = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(372, 220);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholcerText = "";
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Size = new System.Drawing.Size(250, 35);
            this.txtPassword.TabIndex = 18;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlineStyle = false;
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.txtCorreo.BorderRadius = 10;
            this.txtCorreo.BorderSize = 2;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(372, 151);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreo.Multiline = false;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreo.PasswordChar = false;
            this.txtCorreo.PlaceholcerText = "";
            this.txtCorreo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCorreo.Size = new System.Drawing.Size(250, 35);
            this.txtCorreo.TabIndex = 17;
            this.txtCorreo.Texts = "";
            this.txtCorreo.UnderlineStyle = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(312, 17);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(17, 400);
            this.bunifuSeparator1.TabIndex = 16;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(368, 87);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(53, 20);
            this.txtUsuario.TabIndex = 14;
            this.txtUsuario.Text = "label4";
            // 
            // picPassword
            // 
            this.picPassword.Image = global::AMusic.Properties.Resources.closeeye;
            this.picPassword.Location = new System.Drawing.Point(628, 219);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(52, 35);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassword.TabIndex = 13;
            this.picPassword.TabStop = false;
            this.picPassword.Click += new System.EventHandler(this.picPassword_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(368, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(368, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(368, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Correo";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(368, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 20);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Usuario";
            // 
            // picFoto
            // 
            this.picFoto.Location = new System.Drawing.Point(23, 87);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(259, 231);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 0;
            this.picFoto.TabStop = false;
            // 
            // tabSeguidos
            // 
            this.tabSeguidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tabSeguidos.Controls.Add(this.lstUsuarios);
            this.tabSeguidos.Location = new System.Drawing.Point(4, 25);
            this.tabSeguidos.Name = "tabSeguidos";
            this.tabSeguidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeguidos.Size = new System.Drawing.Size(710, 518);
            this.tabSeguidos.TabIndex = 1;
            this.tabSeguidos.Text = "Seguidos";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.lstUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsuarios.ForeColor = System.Drawing.Color.White;
            this.lstUsuarios.FullRowSelect = true;
            this.lstUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstUsuarios.HideSelection = false;
            this.lstUsuarios.Location = new System.Drawing.Point(29, 40);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(427, 410);
            this.lstUsuarios.TabIndex = 0;
            this.lstUsuarios.UseCompatibleStateImageBehavior = false;
            this.lstUsuarios.View = System.Windows.Forms.View.Details;
            this.lstUsuarios.DoubleClick += new System.EventHandler(this.lstUsuarios_DoubleClick);
            // 
            // tabPlaylist
            // 
            this.tabPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.tabPlaylist.Controls.Add(this.lstPlaylist);
            this.tabPlaylist.Location = new System.Drawing.Point(4, 25);
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlaylist.Size = new System.Drawing.Size(710, 518);
            this.tabPlaylist.TabIndex = 2;
            this.tabPlaylist.Text = "Playlist";
            // 
            // lstPlaylist
            // 
            this.lstPlaylist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.lstPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlaylist.ForeColor = System.Drawing.Color.White;
            this.lstPlaylist.FullRowSelect = true;
            this.lstPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstPlaylist.HideSelection = false;
            this.lstPlaylist.Location = new System.Drawing.Point(42, 42);
            this.lstPlaylist.Name = "lstPlaylist";
            this.lstPlaylist.Size = new System.Drawing.Size(427, 410);
            this.lstPlaylist.TabIndex = 1;
            this.lstPlaylist.UseCompatibleStateImageBehavior = false;
            this.lstPlaylist.View = System.Windows.Forms.View.Details;
            this.lstPlaylist.DoubleClick += new System.EventHandler(this.lstPlaylist_DoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AMusic.Properties.Resources.icons8_macos_cerrar_90;
            this.pictureBox1.Location = new System.Drawing.Point(688, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(745, 596);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabEditarPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEditarUsuario";
            this.tabEditarPerfil.ResumeLayout(false);
            this.tabPerfil.ResumeLayout(false);
            this.tabPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.tabSeguidos.ResumeLayout(false);
            this.tabPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEditarPerfil;
        private System.Windows.Forms.TabPage tabPerfil;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.TabPage tabSeguidos;
        private System.Windows.Forms.ListView lstUsuarios;
        private System.Windows.Forms.TabPage tabPlaylist;
        private System.Windows.Forms.ListView lstPlaylist;
        private txtRedondo txtTelefono;
        private txtRedondo txtPassword;
        private txtRedondo txtCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BotonRedondo btnCancelar;
        private BotonRedondo btnAceptar;
        private BotonRedondo btnActualizar;
        private BotonRedondo btnCambiarFoto;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}