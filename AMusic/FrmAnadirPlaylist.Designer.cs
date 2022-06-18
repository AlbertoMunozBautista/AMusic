
namespace AMusic
{
    partial class FrmAnadirPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnadirPlaylist));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new AMusic.txtRedondo();
            this.chkPublico = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.btnCancelar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSiguiente = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de la Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(164, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 34);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pública";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.txtNombre.BorderFocusColor = System.Drawing.Color.White;
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(131, 134);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholcerText = "";
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.Size = new System.Drawing.Size(312, 35);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlineStyle = true;
            // 
            // chkPublico
            // 
            this.chkPublico.AllowBindingControlAnimation = true;
            this.chkPublico.AllowBindingControlColorChanges = false;
            this.chkPublico.AllowBindingControlLocation = true;
            this.chkPublico.AllowCheckBoxAnimation = false;
            this.chkPublico.AllowCheckmarkAnimation = true;
            this.chkPublico.AllowOnHoverStates = true;
            this.chkPublico.AutoCheck = true;
            this.chkPublico.BackColor = System.Drawing.Color.Transparent;
            this.chkPublico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chkPublico.BackgroundImage")));
            this.chkPublico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chkPublico.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.chkPublico.BorderRadius = 12;
            this.chkPublico.Checked = true;
            this.chkPublico.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Checked;
            this.chkPublico.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkPublico.CustomCheckmarkImage = null;
            this.chkPublico.Location = new System.Drawing.Point(330, 232);
            this.chkPublico.MinimumSize = new System.Drawing.Size(17, 17);
            this.chkPublico.Name = "chkPublico";
            this.chkPublico.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chkPublico.OnCheck.BorderRadius = 12;
            this.chkPublico.OnCheck.BorderThickness = 2;
            this.chkPublico.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.chkPublico.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.chkPublico.OnCheck.CheckmarkThickness = 2;
            this.chkPublico.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.chkPublico.OnDisable.BorderRadius = 12;
            this.chkPublico.OnDisable.BorderThickness = 2;
            this.chkPublico.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPublico.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.chkPublico.OnDisable.CheckmarkThickness = 2;
            this.chkPublico.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPublico.OnHoverChecked.BorderRadius = 12;
            this.chkPublico.OnHoverChecked.BorderThickness = 2;
            this.chkPublico.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPublico.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.chkPublico.OnHoverChecked.CheckmarkThickness = 2;
            this.chkPublico.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.chkPublico.OnHoverUnchecked.BorderRadius = 12;
            this.chkPublico.OnHoverUnchecked.BorderThickness = 1;
            this.chkPublico.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPublico.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.chkPublico.OnUncheck.BorderRadius = 12;
            this.chkPublico.OnUncheck.BorderThickness = 1;
            this.chkPublico.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.chkPublico.Size = new System.Drawing.Size(21, 21);
            this.chkPublico.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.chkPublico.TabIndex = 5;
            this.chkPublico.ThreeState = false;
            this.chkPublico.ToolTipText = null;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AllowAnimations = true;
            this.btnCancelar.AllowMouseEffects = true;
            this.btnCancelar.AllowToggling = false;
            this.btnCancelar.AnimationSpeed = 200;
            this.btnCancelar.AutoGenerateColors = false;
            this.btnCancelar.AutoRoundBorders = false;
            this.btnCancelar.AutoSizeLeftIcon = true;
            this.btnCancelar.AutoSizeRightIcon = true;
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.ButtonTextMarginLeft = 0;
            this.btnCancelar.ColorContrastOnClick = 45;
            this.btnCancelar.ColorContrastOnHover = 45;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnCancelar.CustomizableEdges = borderEdges1;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancelar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCancelar.IconMarginLeft = 11;
            this.btnCancelar.IconPadding = 10;
            this.btnCancelar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCancelar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCancelar.IconSize = 25;
            this.btnCancelar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnCancelar.IdleBorderRadius = 10;
            this.btnCancelar.IdleBorderThickness = 2;
            this.btnCancelar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCancelar.IdleIconLeftImage = null;
            this.btnCancelar.IdleIconRightImage = null;
            this.btnCancelar.IndicateFocus = false;
            this.btnCancelar.Location = new System.Drawing.Point(75, 335);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCancelar.OnDisabledState.BorderRadius = 10;
            this.btnCancelar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnDisabledState.BorderThickness = 2;
            this.btnCancelar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancelar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCancelar.OnDisabledState.IconLeftImage = null;
            this.btnCancelar.OnDisabledState.IconRightImage = null;
            this.btnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.BorderRadius = 10;
            this.btnCancelar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.onHoverState.BorderThickness = 2;
            this.btnCancelar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnCancelar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.onHoverState.IconLeftImage = null;
            this.btnCancelar.onHoverState.IconRightImage = null;
            this.btnCancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnCancelar.OnIdleState.BorderRadius = 10;
            this.btnCancelar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnIdleState.BorderThickness = 2;
            this.btnCancelar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCancelar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnIdleState.IconLeftImage = null;
            this.btnCancelar.OnIdleState.IconRightImage = null;
            this.btnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.BorderRadius = 10;
            this.btnCancelar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCancelar.OnPressedState.BorderThickness = 2;
            this.btnCancelar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnCancelar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.OnPressedState.IconLeftImage = null;
            this.btnCancelar.OnPressedState.IconRightImage = null;
            this.btnCancelar.Size = new System.Drawing.Size(196, 56);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCancelar.TextMarginLeft = 0;
            this.btnCancelar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCancelar.UseDefaultRadiusAndThickness = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AllowAnimations = true;
            this.btnSiguiente.AllowMouseEffects = true;
            this.btnSiguiente.AllowToggling = false;
            this.btnSiguiente.AnimationSpeed = 200;
            this.btnSiguiente.AutoGenerateColors = false;
            this.btnSiguiente.AutoRoundBorders = false;
            this.btnSiguiente.AutoSizeLeftIcon = true;
            this.btnSiguiente.AutoSizeRightIcon = true;
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiguiente.ButtonText = "Siguiente";
            this.btnSiguiente.ButtonTextMarginLeft = 0;
            this.btnSiguiente.ColorContrastOnClick = 45;
            this.btnSiguiente.ColorContrastOnHover = 45;
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSiguiente.CustomizableEdges = borderEdges2;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiguiente.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiguiente.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiguiente.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiguiente.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSiguiente.IconMarginLeft = 11;
            this.btnSiguiente.IconPadding = 10;
            this.btnSiguiente.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSiguiente.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSiguiente.IconSize = 25;
            this.btnSiguiente.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSiguiente.IdleBorderRadius = 10;
            this.btnSiguiente.IdleBorderThickness = 2;
            this.btnSiguiente.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSiguiente.IdleIconLeftImage = null;
            this.btnSiguiente.IdleIconRightImage = null;
            this.btnSiguiente.IndicateFocus = false;
            this.btnSiguiente.Location = new System.Drawing.Point(300, 335);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSiguiente.OnDisabledState.BorderRadius = 10;
            this.btnSiguiente.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiguiente.OnDisabledState.BorderThickness = 2;
            this.btnSiguiente.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSiguiente.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSiguiente.OnDisabledState.IconLeftImage = null;
            this.btnSiguiente.OnDisabledState.IconRightImage = null;
            this.btnSiguiente.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiguiente.onHoverState.BorderRadius = 10;
            this.btnSiguiente.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiguiente.onHoverState.BorderThickness = 2;
            this.btnSiguiente.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnSiguiente.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.onHoverState.IconLeftImage = null;
            this.btnSiguiente.onHoverState.IconRightImage = null;
            this.btnSiguiente.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSiguiente.OnIdleState.BorderRadius = 10;
            this.btnSiguiente.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiguiente.OnIdleState.BorderThickness = 2;
            this.btnSiguiente.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.btnSiguiente.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.OnIdleState.IconLeftImage = null;
            this.btnSiguiente.OnIdleState.IconRightImage = null;
            this.btnSiguiente.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiguiente.OnPressedState.BorderRadius = 10;
            this.btnSiguiente.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSiguiente.OnPressedState.BorderThickness = 2;
            this.btnSiguiente.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnSiguiente.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.OnPressedState.IconLeftImage = null;
            this.btnSiguiente.OnPressedState.IconRightImage = null;
            this.btnSiguiente.Size = new System.Drawing.Size(196, 56);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSiguiente.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSiguiente.TextMarginLeft = 0;
            this.btnSiguiente.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSiguiente.UseDefaultRadiusAndThickness = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmAnadirPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.chkPublico);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAnadirPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAnadirPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private txtRedondo txtNombre;
        private Bunifu.UI.WinForms.BunifuCheckBox chkPublico;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCancelar;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSiguiente;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}