
namespace AMusic
{
    partial class FrmReproductorMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReproductorMusica));
            this.lstCanciones = new System.Windows.Forms.ListBox();
            this.lblArtista = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.picCaratula = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proCancion = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.lblTiempo1 = new System.Windows.Forms.Label();
            this.lblTiempo2 = new System.Windows.Forms.Label();
            this.btnSiguiente = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnAnterior = new Bunifu.UI.WinForms.BunifuImageButton();
            this.play = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPausa = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnStop = new Bunifu.UI.WinForms.BunifuImageButton();
            this.imaSonido = new Bunifu.UI.WinForms.BunifuImageButton();
            this.barSonido = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblSonido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCanciones
            // 
            this.lstCanciones.BackColor = System.Drawing.Color.Black;
            this.lstCanciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCanciones.ForeColor = System.Drawing.Color.White;
            this.lstCanciones.FormattingEnabled = true;
            this.lstCanciones.ItemHeight = 21;
            this.lstCanciones.Location = new System.Drawing.Point(292, 126);
            this.lstCanciones.Name = "lstCanciones";
            this.lstCanciones.Size = new System.Drawing.Size(1018, 361);
            this.lstCanciones.TabIndex = 4;
            // 
            // lblArtista
            // 
            this.lblArtista.AutoSize = true;
            this.lblArtista.Font = new System.Drawing.Font("Dubai", 8.25F);
            this.lblArtista.ForeColor = System.Drawing.Color.White;
            this.lblArtista.Location = new System.Drawing.Point(39, 289);
            this.lblArtista.Name = "lblArtista";
            this.lblArtista.Size = new System.Drawing.Size(43, 24);
            this.lblArtista.TabIndex = 20;
            this.lblArtista.Text = "Título";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(39, 256);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(59, 23);
            this.lblTitulo.TabIndex = 19;
            this.lblTitulo.Text = "Título";
            // 
            // picCaratula
            // 
            this.picCaratula.Location = new System.Drawing.Point(22, 9);
            this.picCaratula.Name = "picCaratula";
            this.picCaratula.Size = new System.Drawing.Size(252, 220);
            this.picCaratula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaratula.TabIndex = 18;
            this.picCaratula.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.picCaratula);
            this.bunifuGradientPanel1.Controls.Add(this.lblArtista);
            this.bunifuGradientPanel1.Controls.Add(this.lblTitulo);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-1, 124);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(296, 550);
            this.bunifuGradientPanel1.TabIndex = 21;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1048, 127);
            this.player.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(150)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.lblSonido);
            this.panel1.Controls.Add(this.barSonido);
            this.panel1.Controls.Add(this.imaSonido);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnAnterior);
            this.panel1.Controls.Add(this.btnSiguiente);
            this.panel1.Controls.Add(this.btnPausa);
            this.panel1.Controls.Add(this.play);
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.lblTiempo2);
            this.panel1.Controls.Add(this.lblTiempo1);
            this.panel1.Controls.Add(this.proCancion);
            this.panel1.Location = new System.Drawing.Point(292, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 251);
            this.panel1.TabIndex = 23;
            // 
            // proCancion
            // 
            this.proCancion.AllowAnimations = false;
            this.proCancion.Animation = 0;
            this.proCancion.AnimationSpeed = 220;
            this.proCancion.AnimationStep = 10;
            this.proCancion.BackColor = System.Drawing.Color.White;
            this.proCancion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proCancion.BackgroundImage")));
            this.proCancion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.proCancion.BorderRadius = 9;
            this.proCancion.BorderThickness = 1;
            this.proCancion.Location = new System.Drawing.Point(32, 11);
            this.proCancion.Maximum = 100;
            this.proCancion.MaximumValue = 100;
            this.proCancion.Minimum = 0;
            this.proCancion.MinimumValue = 0;
            this.proCancion.Name = "proCancion";
            this.proCancion.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.proCancion.ProgressBackColor = System.Drawing.Color.White;
            this.proCancion.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.proCancion.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.proCancion.Size = new System.Drawing.Size(697, 19);
            this.proCancion.TabIndex = 0;
            this.proCancion.Value = 0;
            this.proCancion.ValueByTransition = 0;
            // 
            // lblTiempo1
            // 
            this.lblTiempo1.AutoSize = true;
            this.lblTiempo1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo1.ForeColor = System.Drawing.Color.White;
            this.lblTiempo1.Location = new System.Drawing.Point(27, 33);
            this.lblTiempo1.Name = "lblTiempo1";
            this.lblTiempo1.Size = new System.Drawing.Size(59, 30);
            this.lblTiempo1.TabIndex = 13;
            this.lblTiempo1.Text = "0:00";
            // 
            // lblTiempo2
            // 
            this.lblTiempo2.AutoSize = true;
            this.lblTiempo2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo2.ForeColor = System.Drawing.Color.White;
            this.lblTiempo2.Location = new System.Drawing.Point(670, 33);
            this.lblTiempo2.Name = "lblTiempo2";
            this.lblTiempo2.Size = new System.Drawing.Size(59, 30);
            this.lblTiempo2.TabIndex = 14;
            this.lblTiempo2.Text = "0:00";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.ActiveImage = null;
            this.btnSiguiente.AllowAnimations = true;
            this.btnSiguiente.AllowBuffering = false;
            this.btnSiguiente.AllowToggling = false;
            this.btnSiguiente.AllowZooming = true;
            this.btnSiguiente.AllowZoomingOnFocus = false;
            this.btnSiguiente.BackColor = System.Drawing.Color.Transparent;
            this.btnSiguiente.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSiguiente.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.ErrorImage")));
            this.btnSiguiente.FadeWhenInactive = false;
            this.btnSiguiente.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnSiguiente.Image = global::AMusic.Properties.Resources.mayor;
            this.btnSiguiente.ImageActive = null;
            this.btnSiguiente.ImageLocation = null;
            this.btnSiguiente.ImageMargin = 0;
            this.btnSiguiente.ImageSize = new System.Drawing.Size(49, 49);
            this.btnSiguiente.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnSiguiente.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.InitialImage")));
            this.btnSiguiente.Location = new System.Drawing.Point(399, 71);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Rotation = 0;
            this.btnSiguiente.ShowActiveImage = true;
            this.btnSiguiente.ShowCursorChanges = true;
            this.btnSiguiente.ShowImageBorders = true;
            this.btnSiguiente.ShowSizeMarkers = false;
            this.btnSiguiente.Size = new System.Drawing.Size(50, 50);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.ToolTipText = "";
            this.btnSiguiente.WaitOnLoad = false;
            this.btnSiguiente.Zoom = 0;
            this.btnSiguiente.ZoomSpeed = 10;
            // 
            // btnAnterior
            // 
            this.btnAnterior.ActiveImage = null;
            this.btnAnterior.AllowAnimations = true;
            this.btnAnterior.AllowBuffering = false;
            this.btnAnterior.AllowToggling = false;
            this.btnAnterior.AllowZooming = true;
            this.btnAnterior.AllowZoomingOnFocus = false;
            this.btnAnterior.BackColor = System.Drawing.Color.Transparent;
            this.btnAnterior.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAnterior.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.ErrorImage")));
            this.btnAnterior.FadeWhenInactive = false;
            this.btnAnterior.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAnterior.Image = global::AMusic.Properties.Resources.menor;
            this.btnAnterior.ImageActive = null;
            this.btnAnterior.ImageLocation = null;
            this.btnAnterior.ImageMargin = 0;
            this.btnAnterior.ImageSize = new System.Drawing.Size(49, 49);
            this.btnAnterior.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnAnterior.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.InitialImage")));
            this.btnAnterior.Location = new System.Drawing.Point(284, 71);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Rotation = 0;
            this.btnAnterior.ShowActiveImage = true;
            this.btnAnterior.ShowCursorChanges = true;
            this.btnAnterior.ShowImageBorders = true;
            this.btnAnterior.ShowSizeMarkers = false;
            this.btnAnterior.Size = new System.Drawing.Size(50, 50);
            this.btnAnterior.TabIndex = 16;
            this.btnAnterior.ToolTipText = "";
            this.btnAnterior.WaitOnLoad = false;
            this.btnAnterior.Zoom = 0;
            this.btnAnterior.ZoomSpeed = 10;
            // 
            // play
            // 
            this.play.ActiveImage = null;
            this.play.AllowAnimations = true;
            this.play.AllowBuffering = false;
            this.play.AllowToggling = false;
            this.play.AllowZooming = true;
            this.play.AllowZoomingOnFocus = false;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.play.ErrorImage = ((System.Drawing.Image)(resources.GetObject("play.ErrorImage")));
            this.play.FadeWhenInactive = false;
            this.play.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.play.Image = global::AMusic.Properties.Resources.play2;
            this.play.ImageActive = null;
            this.play.ImageLocation = null;
            this.play.ImageMargin = 0;
            this.play.ImageSize = new System.Drawing.Size(24, 24);
            this.play.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.play.InitialImage = ((System.Drawing.Image)(resources.GetObject("play.InitialImage")));
            this.play.Location = new System.Drawing.Point(293, 84);
            this.play.Name = "play";
            this.play.Rotation = 0;
            this.play.ShowActiveImage = true;
            this.play.ShowCursorChanges = true;
            this.play.ShowImageBorders = true;
            this.play.ShowSizeMarkers = false;
            this.play.Size = new System.Drawing.Size(25, 25);
            this.play.TabIndex = 18;
            this.play.ToolTipText = "";
            this.play.WaitOnLoad = false;
            this.play.Zoom = 0;
            this.play.ZoomSpeed = 10;
            // 
            // pause
            // 
            this.pause.ActiveImage = null;
            this.pause.AllowAnimations = true;
            this.pause.AllowBuffering = false;
            this.pause.AllowToggling = false;
            this.pause.AllowZooming = true;
            this.pause.AllowZoomingOnFocus = false;
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.pause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pause.ErrorImage")));
            this.pause.FadeWhenInactive = false;
            this.pause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.pause.Image = global::AMusic.Properties.Resources.pase;
            this.pause.ImageActive = null;
            this.pause.ImageLocation = null;
            this.pause.ImageMargin = 0;
            this.pause.ImageSize = new System.Drawing.Size(24, 24);
            this.pause.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.pause.InitialImage = ((System.Drawing.Image)(resources.GetObject("pause.InitialImage")));
            this.pause.Location = new System.Drawing.Point(415, 84);
            this.pause.Name = "pause";
            this.pause.Rotation = 0;
            this.pause.ShowActiveImage = true;
            this.pause.ShowCursorChanges = true;
            this.pause.ShowImageBorders = true;
            this.pause.ShowSizeMarkers = false;
            this.pause.Size = new System.Drawing.Size(25, 25);
            this.pause.TabIndex = 17;
            this.pause.ToolTipText = "";
            this.pause.WaitOnLoad = false;
            this.pause.Zoom = 0;
            this.pause.ZoomSpeed = 10;
            // 
            // btnPausa
            // 
            this.btnPausa.ActiveImage = null;
            this.btnPausa.AllowAnimations = true;
            this.btnPausa.AllowBuffering = false;
            this.btnPausa.AllowToggling = false;
            this.btnPausa.AllowZooming = true;
            this.btnPausa.AllowZoomingOnFocus = false;
            this.btnPausa.BackColor = System.Drawing.Color.Transparent;
            this.btnPausa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPausa.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPausa.ErrorImage")));
            this.btnPausa.FadeWhenInactive = false;
            this.btnPausa.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPausa.Image = global::AMusic.Properties.Resources.pase;
            this.btnPausa.ImageActive = null;
            this.btnPausa.ImageLocation = null;
            this.btnPausa.ImageMargin = 0;
            this.btnPausa.ImageSize = new System.Drawing.Size(60, 60);
            this.btnPausa.ImageZoomSize = new System.Drawing.Size(61, 61);
            this.btnPausa.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPausa.InitialImage")));
            this.btnPausa.Location = new System.Drawing.Point(336, 65);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Rotation = 0;
            this.btnPausa.ShowActiveImage = true;
            this.btnPausa.ShowCursorChanges = true;
            this.btnPausa.ShowImageBorders = true;
            this.btnPausa.ShowSizeMarkers = false;
            this.btnPausa.Size = new System.Drawing.Size(61, 61);
            this.btnPausa.TabIndex = 19;
            this.btnPausa.ToolTipText = "";
            this.btnPausa.WaitOnLoad = false;
            this.btnPausa.Zoom = 0;
            this.btnPausa.ZoomSpeed = 10;
            // 
            // btnStop
            // 
            this.btnStop.ActiveImage = null;
            this.btnStop.AllowAnimations = true;
            this.btnStop.AllowBuffering = false;
            this.btnStop.AllowToggling = false;
            this.btnStop.AllowZooming = true;
            this.btnStop.AllowZoomingOnFocus = false;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnStop.ErrorImage")));
            this.btnStop.FadeWhenInactive = false;
            this.btnStop.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnStop.Image = global::AMusic.Properties.Resources.square;
            this.btnStop.ImageActive = null;
            this.btnStop.ImageLocation = null;
            this.btnStop.ImageMargin = 0;
            this.btnStop.ImageSize = new System.Drawing.Size(29, 29);
            this.btnStop.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btnStop.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnStop.InitialImage")));
            this.btnStop.Location = new System.Drawing.Point(459, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Rotation = 0;
            this.btnStop.ShowActiveImage = true;
            this.btnStop.ShowCursorChanges = true;
            this.btnStop.ShowImageBorders = true;
            this.btnStop.ShowSizeMarkers = false;
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 20;
            this.btnStop.ToolTipText = "";
            this.btnStop.WaitOnLoad = false;
            this.btnStop.Zoom = 0;
            this.btnStop.ZoomSpeed = 10;
            // 
            // imaSonido
            // 
            this.imaSonido.ActiveImage = null;
            this.imaSonido.AllowAnimations = true;
            this.imaSonido.AllowBuffering = false;
            this.imaSonido.AllowToggling = false;
            this.imaSonido.AllowZooming = true;
            this.imaSonido.AllowZoomingOnFocus = false;
            this.imaSonido.BackColor = System.Drawing.Color.Transparent;
            this.imaSonido.DialogResult = System.Windows.Forms.DialogResult.None;
            this.imaSonido.ErrorImage = ((System.Drawing.Image)(resources.GetObject("imaSonido.ErrorImage")));
            this.imaSonido.FadeWhenInactive = false;
            this.imaSonido.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.imaSonido.Image = global::AMusic.Properties.Resources.sound;
            this.imaSonido.ImageActive = null;
            this.imaSonido.ImageLocation = null;
            this.imaSonido.ImageMargin = 0;
            this.imaSonido.ImageSize = new System.Drawing.Size(24, 24);
            this.imaSonido.ImageZoomSize = new System.Drawing.Size(25, 25);
            this.imaSonido.InitialImage = ((System.Drawing.Image)(resources.GetObject("imaSonido.InitialImage")));
            this.imaSonido.Location = new System.Drawing.Point(521, 138);
            this.imaSonido.Name = "imaSonido";
            this.imaSonido.Rotation = 0;
            this.imaSonido.ShowActiveImage = true;
            this.imaSonido.ShowCursorChanges = true;
            this.imaSonido.ShowImageBorders = true;
            this.imaSonido.ShowSizeMarkers = false;
            this.imaSonido.Size = new System.Drawing.Size(25, 25);
            this.imaSonido.TabIndex = 21;
            this.imaSonido.ToolTipText = "";
            this.imaSonido.WaitOnLoad = false;
            this.imaSonido.Zoom = 0;
            this.imaSonido.ZoomSpeed = 10;
            // 
            // barSonido
            // 
            this.barSonido.AllowCursorChanges = true;
            this.barSonido.AllowHomeEndKeysDetection = false;
            this.barSonido.AllowIncrementalClickMoves = true;
            this.barSonido.AllowMouseDownEffects = false;
            this.barSonido.AllowMouseHoverEffects = false;
            this.barSonido.AllowScrollingAnimations = true;
            this.barSonido.AllowScrollKeysDetection = true;
            this.barSonido.AllowScrollOptionsMenu = true;
            this.barSonido.AllowShrinkingOnFocusLost = false;
            this.barSonido.BackColor = System.Drawing.Color.Transparent;
            this.barSonido.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barSonido.BackgroundImage")));
            this.barSonido.BindingContainer = null;
            this.barSonido.BorderRadius = 1;
            this.barSonido.BorderThickness = 1;
            this.barSonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barSonido.DrawThickBorder = false;
            this.barSonido.DurationBeforeShrink = 2000;
            this.barSonido.ElapsedColor = System.Drawing.Color.Black;
            this.barSonido.LargeChange = 10;
            this.barSonido.Location = new System.Drawing.Point(564, 135);
            this.barSonido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barSonido.Maximum = 100;
            this.barSonido.Minimum = 0;
            this.barSonido.MinimumSize = new System.Drawing.Size(0, 31);
            this.barSonido.MinimumThumbLength = 18;
            this.barSonido.Name = "barSonido";
            this.barSonido.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.barSonido.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.barSonido.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.barSonido.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.barSonido.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.barSonido.ShrinkSizeLimit = 3;
            this.barSonido.Size = new System.Drawing.Size(127, 31);
            this.barSonido.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.barSonido.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.barSonido.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.barSonido.SmallChange = 1;
            this.barSonido.TabIndex = 22;
            this.barSonido.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.barSonido.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.barSonido.ThumbLength = 18;
            this.barSonido.ThumbMargin = 1;
            this.barSonido.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Large;
            this.barSonido.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.barSonido.Value = 100;
            // 
            // lblSonido
            // 
            this.lblSonido.AutoSize = true;
            this.lblSonido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonido.ForeColor = System.Drawing.Color.White;
            this.lblSonido.Location = new System.Drawing.Point(697, 140);
            this.lblSonido.Name = "lblSonido";
            this.lblSonido.Size = new System.Drawing.Size(37, 21);
            this.lblSonido.TabIndex = 24;
            this.lblSonido.Text = "100";
            // 
            // FrmReproductorMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1048, 666);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.lstCanciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReproductorMusica";
            this.Text = "FrmReproductorMusica";
            ((System.ComponentModel.ISupportInitialize)(this.picCaratula)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCanciones;
        private System.Windows.Forms.Label lblArtista;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picCaratula;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSonido;
        private Bunifu.UI.WinForms.BunifuHSlider barSonido;
        private Bunifu.UI.WinForms.BunifuImageButton imaSonido;
        private Bunifu.UI.WinForms.BunifuImageButton btnStop;
        private Bunifu.UI.WinForms.BunifuImageButton btnAnterior;
        private Bunifu.UI.WinForms.BunifuImageButton btnSiguiente;
        private Bunifu.UI.WinForms.BunifuImageButton btnPausa;
        private Bunifu.UI.WinForms.BunifuImageButton play;
        private Bunifu.UI.WinForms.BunifuImageButton pause;
        private System.Windows.Forms.Label lblTiempo2;
        private System.Windows.Forms.Label lblTiempo1;
        private Bunifu.UI.WinForms.BunifuProgressBar proCancion;
    }
}